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
                connection.ExecuteQuery(query);
                MessageBox.Show("Conference created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Edit an existing conference
        public void EditConference(int id, Dictionary<string, object> updatedFields)
        {
            if (updatedFields.Count == 0)
            {
                MessageBox.Show("No fields to update.");
                return;
            }

            List<string> updateParts = new List<string>();

            foreach (var field in updatedFields)
            {
                if (field.Value is DateTime)
                {
                    updateParts.Add($"{field.Key} = '{((DateTime)field.Value):yyyy-MM-dd}'");
                }
                else if (field.Value is int)
                {
                    updateParts.Add($"{field.Key} = {field.Value}");
                }
                else
                {
                    updateParts.Add($"{field.Key} = '{field.Value}'");
                }
            }

            string updateQuery = $"UPDATE conferences_table SET {string.Join(", ", updateParts)} WHERE conferenceId = {id};";

            try
            {
                connection.ExecuteQuery(updateQuery);
                MessageBox.Show("Conference updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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