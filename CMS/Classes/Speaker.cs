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

        // Constructor
        public Speaker() : base()
        {
            AccountType = "Speaker";
            connection = new DBConnection();
        }

        public Speaker(int userID, string userName, string password)
            : base(userID, userName, password, "Speaker")
        {
            connection = new DBConnection();
        }

        // Get a list of all speakers
        public List<Speaker> GetSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>();
            string query = "SELECT * FROM users_table WHERE accountType = 'Speaker';";

            try
            {
                if (connection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        speakers.Add(new Speaker
                        {
                            UserID = Convert.ToInt32(reader["userID"]),
                            UserName = reader["userName"].ToString(),
                            Password = reader["password"].ToString()
                        });
                    }

                    reader.Close();
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving speakers: {ex.Message}");
            }

            return speakers;
        }


        // Edit speaker details
        public void EditSpeaker(int userID, string newUserName, string newPassword)
        {
            string query = $"UPDATE users_table SET userName = '{newUserName}', password = '{newPassword}' WHERE userID = '{userID}' AND accountType = 'Speaker';";
            try
            {
                connection.ExecuteQuery(query);
                Console.WriteLine("Speaker details updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating speaker details: {ex.Message}");
            }
        }

        // Assign speaker to conference
        public void AssignSpeakerToConference(int userID, int conferenceID)
        {
            string query = $"INSERT INTO conference_speakers (conferenceID, userID) VALUES ('{conferenceID}', '{userID}');";
            try
            {
                connection.ExecuteQuery(query);
                Console.WriteLine("Speaker assigned to the conference successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error assigning speaker to the conference: {ex.Message}");
            }
        }

        // Remove speaker from conference
        public void RemoveSpeakerFromConference(int userID, int conferenceID)
        {
            string query = $"DELETE FROM conference_speakers WHERE conferenceID = '{conferenceID}' AND userID = '{userID}';";
            try
            {
                connection.ExecuteQuery(query);
                Console.WriteLine("Speaker removed from the conference successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing speaker from the conference: {ex.Message}");
            }
        }

    }
}