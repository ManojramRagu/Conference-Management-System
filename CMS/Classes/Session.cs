using DatabaseLearning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CMS.Classes
{
    internal class Session
    {
        private DBConnection connection;

        public int ConferenceID { get; set; }
        public string ConferenceName { get; set; }
        public int SessionID { get; set; }
        public string SessionTitle { get; set; }
        public string SessionDescription { get; set; }
        public string SessionTime { get; set; }
        public DateTime ConferenceDate { get; set; }
        public string Speaker { get; set; }
        public string Venue { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        // SESSION CONSTRUCTOR
        public Session(int sessionID, string sessionTitle, string sessionDescription,int conferenceID, string conferenceName, DateTime conferenceDate, string speaker, string venue)
        {
            ConferenceID = conferenceID;
            ConferenceName = conferenceName;
            SessionID = sessionID;
            SessionTitle = sessionTitle;
            SessionDescription = sessionDescription;
            ConferenceDate = conferenceDate;
            Speaker = speaker;
            Venue = venue;
        }

        // SESSION CONSTRUCTOR
        public Session()
        {
            connection = new DBConnection();
        }

        // CREATE SESSION METHOD
        public void CreateSession(string sessionTitle, string sessionDescription, int conferenceID, string venue, DateTime startTime, DateTime endTime, int speakerID)
        {
            string query = $@"
            INSERT INTO sessions_table 
            (conferenceID, sessionTitle, sessionDescription, venue, startTime, endTime) 
            VALUES 
            ('{conferenceID}', '{sessionTitle}', '{sessionDescription}', '{venue}', 
             '{startTime.ToString("HH:mm:ss")}', '{endTime.ToString("HH:mm:ss")}');";


            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Session created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // GET SESSIONS METHOD
        public List<Session> GetSessions()
        {
            List<Session> sessions = new List<Session>();
            string query = "SELECT s.sessionID, s.sessionTitle, s.sessionDescription, s.conferenceID, c.name AS conferenceName, c.date AS conferenceDate, s.venue, s.startTime, s.endTime, sp.name AS speakerName FROM sessions_table s JOIN conferences_table c ON s.conferenceID = c.conferenceID JOIN session_speakers ss ON s.sessionID = ss.sessionID JOIN speakers_table sp ON ss.speakerID = sp.speakersID";

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
                                    SessionID = Convert.ToInt32(reader["sessionID"]),
                                    ConferenceID = Convert.ToInt32(reader["conferenceID"]),
                                    ConferenceName = reader["conferenceName"].ToString(),
                                    ConferenceDate = Convert.ToDateTime(reader["conferenceDate"]),
                                    SessionTitle = reader["sessionTitle"].ToString(),
                                    SessionDescription = reader["sessionDescription"].ToString(),
                                    Venue = reader["venue"].ToString(),
                                    StartTime = DateTime.Today.Add((TimeSpan)reader["startTime"]),
                                    EndTime = DateTime.Today.Add((TimeSpan)reader["endTime"]),
                                    Speaker = reader["speakerName"].ToString()
                                };

                                sessions.Add(session);
                            }
                        }

                        connection.CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return sessions;
        }

        // EDIT SESSIONS METHOD
        public void EditSessions(int conferenceID, string conferenceName, int sessionID, string sessionTitle, string sessionDescription, DateTime conferenceDate, string speaker, string venue)
        {
            string query = $@"UPDATE sessions_table 
                    SET 
                        conferenceID = '{conferenceID}',
                        conferenceName = '{conferenceName}',
                        sessionTitle = '{sessionTitle}',
                        sessionDescription = '{sessionDescription}',
                        conferenceDate = '{conferenceDate}',
                        speaker = '{speaker}',
                        venue = '{venue}'
                    WHERE 
                        sessionID = '{sessionID}';
            ";

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    {
                        cmd.ExecuteNonQuery(); // Executes the update query
                    }

                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // DELETE SESSION METHOD
        public void DeleteSession(int sessionID)
        {
            string query = $@"
            DELETE ss, s
            FROM session_speakers ss
            JOIN sessions_table s ON ss.sessionID = s.sessionID
            WHERE s.sessionID = '{sessionID}';";
            connection.ExecuteQuery(query);
            MessageBox.Show("Session deleted successfully.");
        }
    }
}