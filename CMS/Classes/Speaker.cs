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

        // CREATE SPEAKER
        public void AddSpeaker(string name, string bio, string email, int phone, int userId)
        {
            string query = $"INSERT INTO speakers_table (name, bio, email, phone, userID) VALUES ('{name}', '{bio}', '{email}', '{phone}', '{userId}');";

            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Speaker added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding speaker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // FETCH SPEAKERS
        public List<Speaker> GetSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>();
            string query = "SELECT speakersID, name, bio, email, phone FROM speakers_table;\r\n";

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
                            SpeakerID = Convert.ToInt32(reader["speakersID"]),
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
                MessageBox.Show($"Error retrieving speakers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return speakers;
        }

        // EDIT SPEAKER
        public void EditSpeaker(int speakerID, string newName, string newBio, string newEmail, int newPhone)
        {
            string query = $"UPDATE speakers_table SET name = '{newName}', bio = '{newBio}', email = '{newEmail}', phone = '{newPhone}' WHERE speakersID = {speakerID};";

            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Speaker details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating speaker details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // DELETE SPEAKER
        public void DeleteSpeaker(int speakerID)
        {
            string query = $"DELETE FROM speakers_table WHERE speakersID = {speakerID};";

            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Speaker deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting speaker: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // GET ASSIGNED SESSIONS
        public List<Session> GetAssignedSessions(int loggedInUserID)
        {
            List<Session> speakerSessions = new List<Session>();

            string query = $@"
            SELECT 
                s.sessionTitle AS SessionTitle, 
                c.name AS ConferenceName, 
                c.date AS ConferenceDate, 
                c.venue AS Venue,
                s.startTime AS StartTime,
                s.endTime AS EndTime
            FROM sessions_table AS s
            INNER JOIN conferences_table AS c ON s.conferenceID = c.conferenceID
            INNER JOIN session_speakers AS ss ON s.sessionID = ss.sessionID
            INNER JOIN speakers_table AS sp ON ss.speakerID = sp.speakersID
            WHERE sp.userID = {loggedInUserID};";

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
                                Session session = new Session
                                {
                                    ConferenceName = reader["ConferenceName"].ToString(),
                                    ConferenceDate = Convert.ToDateTime(reader["ConferenceDate"]),
                                    Venue = reader["Venue"].ToString(),
                                    SessionTitle = reader["SessionTitle"].ToString(),
                                    StartTime = DateTime.Today.Add((TimeSpan)reader["startTime"]),
                                    EndTime = DateTime.Today.Add((TimeSpan)reader["endTime"]),
                                };

                                speakerSessions.Add(session);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving sessions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseConnection();
            }

            return speakerSessions;
        }
    }
}