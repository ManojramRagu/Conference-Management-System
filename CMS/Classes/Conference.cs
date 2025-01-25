using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DatabaseLearning;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMS
{
    internal class Conference
    {
        public int ConferenceId { get; set; }
        public string ConferenceName { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }

        private DBConnection connection;

        public Conference()
        {
            connection = new DBConnection();
        }

        // Create a new conference
        public void CreateConference(string name, DateTime date, string venue, string description, int capacity)
        {
            string query = $"INSERT INTO conferences_table (name, date, venue, description, capacity) " +
                           $"VALUES ('{name}', '{date:yyyy-MM-dd}', '{venue}', '{description}', {capacity});";

            try
            {
<<<<<<< HEAD
                connection.ExecuteQuery(query); // Assume this method handles connection management
=======
                connection.ExecuteQuery(query);
>>>>>>> 5a6db96161a513cc06120346d0a83c83a3032874
                MessageBox.Show("Conference created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Edit an existing conference
        public void EditConference(int id, string name, DateTime date, string venue, string description, int capacity)
        {
            string query = $"UPDATE conferences_table SET ";

            List<string> updateFields = new List<string>();

            if (!string.IsNullOrEmpty(name))
                updateFields.Add($"name = '{name}'");
            if (!string.IsNullOrEmpty(venue))
                updateFields.Add($"venue = '{venue}'");
            if (!string.IsNullOrEmpty(description))
                updateFields.Add($"description = '{description}'");
            if (date != DateTime.MinValue)
                updateFields.Add($"date = '{date:yyyy-MM-dd}'");
            if (capacity > 0)
                updateFields.Add($"capacity = {capacity}");

            if (updateFields.Count > 0)
            {
                query += string.Join(", ", updateFields) + $" WHERE conferenceId = {id};";

                try
                {
                    connection.ExecuteQuery(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No changes detected.");
            }
        }

        // Delete a conference
        public void DeleteConference(int id)
        {
            string query = $"DELETE FROM conferences_table WHERE ConferenceId = '{id}';";
            connection.ExecuteQuery(query);
            MessageBox.Show("Conference deleted successfully.");
        }

        // View conference details
        public void ViewDetails(int id)
        {
            string query = $"SELECT * FROM conferences_table WHERE ConferenceId = '{id}';";
            if (connection.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show($"ID: {reader["ConferenceId"]}, Name: {reader["ConferenceName"]}, Date: {reader["Date"]}, Venue: {reader["Venue"]}, Description: {reader["Description"]}");
                        }
                        else
                        {
                            MessageBox.Show("Conference not found.");
                        }
                    }
                }
                connection.CloseConnection();
            }
        }
        public List<Conference> GetAllConferences()
        {
            List<Conference> conferences = new List<Conference>();
            string query = "SELECT conferenceId, name, date, venue, description, capacity FROM conferences_table";

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Conference conference = new Conference
                                {
                                    ConferenceId = Convert.ToInt32(reader["conferenceID"]),
                                    ConferenceName = reader["name"].ToString(),
                                    Date = Convert.ToDateTime(reader["date"]),
                                    Venue = reader["venue"].ToString(),
                                    Description = reader["description"].ToString(),
                                    Capacity = Convert.ToInt32(reader["capacity"]),
                                };

                                conferences.Add(conference);
                            }
                        }
                    }
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return conferences;
        }
        public Conference GetConferenceById(int id)
        {
            string query = $"SELECT name, date, venue, description, capacity FROM conferences_table WHERE conferenceID = {id}";
            Conference conference = null;

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows && reader.Read())
                            {
                                conference = new Conference
                                {
                                    ConferenceName = reader["name"].ToString(),
                                    Date = Convert.ToDateTime(reader["date"]),
                                    Venue = reader["venue"].ToString(),
                                    Description = reader["description"].ToString(),
                                    Capacity = Convert.ToInt32(reader["capacity"])
                                };
                            }
                        }
                    }

                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return conference;
        }

    }
}