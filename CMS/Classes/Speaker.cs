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

namespace CMS.Classes
{
    internal class Speaker : User
    {
        private DBConnection connection;

        // Default constructor
        public Speaker()
        {
            connection = new DBConnection();
        }

        // User constructor
        public Speaker(int userID, string userName, string password, string accountType) : base(userID, userName, password, accountType)
        {
            connection = new DBConnection();
        }

        // Add speaker
        public void AddSpeaker(int userID, string userName, string password)
        {
            string accountType = "Speaker";
            AddUser(userID, userName, password, accountType);
            MessageBox.Show("Speaker added successfully.");
        }

        // Edit speaker details
        public void EditSpeaker(int userID, string userName)
        {
            string query = $"UPDATE users_table SET userName = '{userName}' WHERE userID = '{userID}';";
            connection.ExecuteQuery(query);
            MessageBox.Show("Speaker details updated successfully.");
        }

        // Delete speaker
        public void DeleteSpeaker(int userID)
        {
            string query = $"DELETE FROM users_table WHERE userID = '{userID}';";
            connection.ExecuteQuery(query);
            MessageBox.Show("Speaker deleted successfully.");
        }

        // List of all speakers
        public List<Speaker> GetSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>();
            string query = "SELECT * FROM users_table WHERE accountType = 'Speaker';";

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
                                speakers.Add(new Speaker
                                {
                                    UserID = Convert.ToInt32(reader["userID"]),
                                    UserName = reader["userName"].ToString(),
                                    Password = reader["password"].ToString(),
                                    AccountType = reader["accountType"].ToString()
                                });
                            }
                        }
                    }

                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving speakers: {ex.Message}");
            }

            return speakers;
        }
    }
}