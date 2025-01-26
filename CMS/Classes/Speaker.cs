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
        public int SpeakerID { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        private DBConnection connection;

        // Constructor
        public Speaker()
        {
            connection = new DBConnection();
        }

        public Speaker(int speakerID, string name, string bio, string email, int phone)
        {
            SpeakerID = speakerID;
            Name = name;
            Bio = bio;
            Email = email;
            Phone = phone;
            connection = new DBConnection();
        }

        // Add speaker
        public void AddSpeaker(string name, string bio, string email, int phone)
        {
            string query = $"INSERT INTO speakers_table (name, bio, email, phone) VALUES ('{name}', '{bio}', '{email}', '{phone}');";

            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Speaker added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding speaker: {ex.Message}");
            }
        }


        // Get list of speakers
        public List<Speaker> GetSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>();
            string query = "SELECT * FROM speakers_table;";

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
                            SpeakerID = Convert.ToInt32(reader["speakerID"]),
                            UserID = Convert.ToInt32(reader["userID"]),
                            Name = reader["name"].ToString(),
                            Bio = reader["bio"].ToString(),
                            Email = reader["email"].ToString(),
                            Phone = Convert.ToInt32(reader["phone"])
                        });
                    }

                    reader.Close();
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving speakers: {ex.Message}");
            }

            return speakers;
        }

        // Edit speaker details
        public void EditSpeaker(int speakerID, string newName, string newBio, string newEmail, int newPhone)
        {
            string query = $"UPDATE speakers_table SET name = '{newName}', bio = '{newBio}', email = '{newEmail}', phone = '{newPhone}' WHERE speakerID = '{speakerID}';";
            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Speaker details updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating speaker details: {ex.Message}");
            }
        }

        public List<string> GetAssignedSessions(int loggedInUserID)
        {
            List<string> sessions = new List<string>();

            // Query to fetch the necessary session details for the logged-in user
            string query = $"SELECT s.title AS SessionTitle, c.name AS ConferenceName, c.venue AS Venue, c.date AS ConferenceDate FROM sessions_table AS s INNER JOIN conferences_table AS c ON s.conferenceID = c.conferenceID INNER JOIN speakers_table AS sp ON s.speakerID = sp.speakersID WHERE sp.userID = '{loggedInUserID}';";

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    {
                        // Use parameterized query to prevent SQL injection
                        cmd.Parameters.AddWithValue("@loggedInUserID", loggedInUserID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Extract required session and conference details
                                string sessionTitle = reader["SessionTitle"].ToString();
                                string conferenceName = reader["ConferenceName"].ToString();
                                string venue = reader["Venue"].ToString();
                                string conferenceDate = Convert.ToDateTime(reader["ConferenceDate"]).ToString("yyyy-MM-dd");
          

                                // Build the session detail string
                                string sessionDetails = $"Session: {sessionTitle}, Conference: {conferenceName}, Venue: {venue}, Date: {conferenceDate}";

                                // Add the session details to the list
                                sessions.Add(sessionDetails);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving sessions: {ex.Message}");
            }
            finally
            {
                connection.CloseConnection();
            }

            return sessions;
        }
    }
}