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
using System.ComponentModel;

namespace CMS
{
    internal class Participant : User
    {
        private DBConnection dbConnection;

        // Class to represent a session item
        public class SessionItem
        {
            [Browsable(false)] // Prevents ConferenceID from appearing in UI
            public int SessionId { get; set; } // Correct SessionId property name
            public string SessionTitle { get; set; }
            [Browsable(false)] // Prevents ConferenceID from appearing in UI
            public int ConferenceID { get; set; }
            public string ConferenceName { get; set; }
            public DateTime ConferenceDate { get; set; }
            public string Speaker { get; set; }
            public string Venue { get; set; }
            public DateTime SessionDate { get; internal set; }
    }

        public Participant()
        {
            dbConnection = new DBConnection(); // Initialize DBConnection
        }

        // Fetch session data and return as a list
        public List<SessionItem> GetSessions()
        {
            List<SessionItem> sessions = new List<SessionItem>();

            if (dbConnection.OpenConnection()) // Open the DB connection from DBConnection
            {
                string query = @"
                    SELECT 
                        s.sessionID,
                        c.date AS ConferenceDate,  
                        c.name AS ConferenceName, 
                        s.title AS SessionTitle,
                        s.venue AS Venue,
                        s.date AS SessionDate, 
                        sp.name AS Speaker 
                    FROM 
                        sessions_table s
                    JOIN 
                        conferences_table c ON s.conferenceID = c.conferenceID
                    JOIN 
                        speakers_table sp ON s.speakerID = sp.speakersID
                    ORDER BY 
                        s.date;";

                MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sessions.Add(new SessionItem
                    {
                        //SessionId = reader.GetInt32(0), // Getting the SessionId from the result
                        ConferenceDate = reader.GetDateTime(1), // Corrected to GetDateTime
                        ConferenceName = reader.GetString(2), // Corrected index
                        SessionTitle = reader.GetString(3), // Corrected index
                        Venue = reader.GetString(4), // Corrected index
                        SessionDate = reader.GetDateTime(5), // Corrected index
                        Speaker = reader.GetString(6) // Corrected index
                    });
                }

                dbConnection.CloseConnection(); // Close the connection from DBConnection
            }
            return sessions;
        }

        public void RegisterUserForSessions(int userID, List<int> selectedSessionIDs, int conferenceID, string conferenceName, Dictionary<int, (string SessionName, string Venue, string Speaker)> sessionDetails)
        {
            if (dbConnection.OpenConnection()) // Open the DB connection from DBConnection
            {
                foreach (int sessionID in selectedSessionIDs)
                {
                    // Skip the session if details are missing
                    if (!sessionDetails.ContainsKey(sessionID)) continue;

                    // Extract session details
                    var details = sessionDetails[sessionID];
                    string sessionName = details.SessionName;
                    string venue = details.Venue;
                    string speaker = details.Speaker;

                    string query = @"
            INSERT INTO registrations_table (Date, Time, ConferenceName, SessionName, Venue, Speaker)
            VALUES (@Date, @Time, @ConferenceName, @SessionName, @Venue, @Speaker)";

                    MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
                    command.Parameters.AddWithValue("@Date", DateTime.Now.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Time", DateTime.Now.ToString("HH:mm:ss"));
                    command.Parameters.AddWithValue("@ConferenceName", conferenceName);
                    command.Parameters.AddWithValue("@SessionName", sessionName);
                    command.Parameters.AddWithValue("@Venue", venue);
                    command.Parameters.AddWithValue("@Speaker", speaker);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(); // Close the connection from DBConnection
            }
        }
    }
}
