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
        public int SpeakerID { get; set; }
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
            string query = @"
        SELECT 
            s.sessionID, 
            s.sessionTitle, 
            s.sessionDescription, 
            s.conferenceID, 
            c.name AS conferenceName, 
            c.date AS conferenceDate, 
            c.venue AS conferenceVenue,   -- Venue is fetched from conferences_table
            s.startTime, 
            s.endTime, 
            sp.name AS speakerName
        FROM sessions_table s 
        JOIN conferences_table c ON s.conferenceID = c.conferenceID 
        JOIN session_speakers ss ON s.sessionID = ss.sessionID 
        JOIN speakers_table sp ON ss.speakerID = sp.speakersID";

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
                                    ConferenceDate = Convert.ToDateTime(reader["conferenceDate"]),  // This is the conference date
                                    Venue = reader["conferenceVenue"].ToString(),  // Venue comes from conferences_table
                                    SessionTitle = reader["sessionTitle"].ToString(),
                                    SessionDescription = reader["sessionDescription"].ToString(),
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
        public void EditSession(int sessionID, string sessionName, int conferenceID, int speakerID, string sessionDescription, DateTime startTime, DateTime endTime)
        {
            // Update the session information in sessions_table
            string updateSessionQuery = "UPDATE sessions_table SET ";
            List<string> updateSessionFields = new List<string>();

            // Add session fields to be updated (if changed)
            if (!string.IsNullOrEmpty(sessionName))
                updateSessionFields.Add($"sessionTitle = '{sessionName}'");
            if (conferenceID > 0)
            if (conferenceID > 0)
                updateSessionFields.Add($"conferenceID = {conferenceID}");
            if (!string.IsNullOrEmpty(sessionDescription))
                updateSessionFields.Add($"sessionDescription = '{sessionDescription}'");
            if (startTime != DateTime.MinValue)
                updateSessionFields.Add($"startTime = '{startTime:HH:mm:ss}'");
            if (endTime != DateTime.MinValue)
                updateSessionFields.Add($"endTime = '{endTime:HH:mm:ss}'");

            if (updateSessionFields.Count > 0)
            {
                // Join the fields and append the sessionID condition
                updateSessionQuery += string.Join(", ", updateSessionFields) + $" WHERE sessionID = {sessionID};";
            }
            else
            {
                MessageBox.Show("No session changes detected.");
                return;
            }

            // Update the session speaker in session_speakers table
            string updateSpeakerQuery = "UPDATE session_speakers SET ";
            List<string> updateSpeakerFields = new List<string>();

            if (speakerID > 0)
                updateSpeakerFields.Add($"speakerID = {speakerID}");

            if (updateSpeakerFields.Count > 0)
            {
                // Join the fields and append the sessionID condition
                updateSpeakerQuery += string.Join(", ", updateSpeakerFields) + $" WHERE sessionID = {sessionID};";
            }
            else
            {
                MessageBox.Show("No speaker changes detected.");
                return;
            }

            try
            {
                // Execute the session update query
                connection.ExecuteQuery(updateSessionQuery);

                // Execute the speaker update query
                connection.ExecuteQuery(updateSpeakerQuery);

                MessageBox.Show("Session and speaker updated successfully!");
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

        // GETTING A SESSION BY IT'S ID
        public Session GetSessionById(int sessionID)
        {
            Session session = null;
            string query = $@"
            SELECT s.sessionID, s.sessionTitle, s.sessionDescription, s.conferenceID, c.name AS conferenceName, c.date AS conferenceDate, 
                   s.venue, s.startTime, s.endTime, sp.name AS speakerName 
            FROM sessions_table s 
            JOIN conferences_table c ON s.conferenceID = c.conferenceID 
            JOIN session_speakers ss ON s.sessionID = ss.sessionID 
            JOIN speakers_table sp ON ss.speakerID = sp.speakersID 
            WHERE s.sessionID = {sessionID};";

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If a record is found
                            {
                                session = new Session
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

            return session; // Returns null if no session found
        }

    }
}