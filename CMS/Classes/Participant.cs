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
    internal class Participant : User
    {
        private DBConnection dbConnection;

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
                                    s.title AS SessionTitle,
                                    s.date AS SessionDate, 
                                    c.conferenceID, 
                                    c.name AS ConferenceName, 
                                    c.date AS ConferenceDate,  
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

                //while (reader.Read())
                //{
                //    sessions.Add(new SessionItem
                //    {
                //        SessionID = reader.GetInt32(0), // Fetch sessionID
                //        SessionTitle = reader.GetString(1), // Fetch session title
                //        ConferenceID = reader.GetInt32(2), // Fetch conferenceID
                //        ConferenceName = reader.GetString(3), // Fetch conference name
                //        ConferenceDate = reader.GetDateTime(4), // Fetch conference date
                //        Speaker = reader.GetString(5) // Fetch speaker name
                //    });
                //}

                while (reader.Read())
                {
                    sessions.Add(new SessionItem
                    {
                        SessionID = reader.GetInt32(0),
                        SessionTitle = reader.GetString(1), // Fetch session title (index 1 based on query order)
                        ConferenceID = reader.GetInt32(2), // Fetch conferenceID
                        ConferenceName = reader.GetString(3), // Fetch conference name
                        ConferenceDate = reader.GetDateTime(4), // Fetch conference date
                        Speaker = reader.GetString(5), // Fetch speaker name
                    });
                }



                dbConnection.CloseConnection(); // Close the connection from DBConnection
            }
            return sessions;
        }

        // Register the user for selected sessions, including conferenceID
        public void RegisterUserForSessions(int userID, List<int> selectedSessionIDs, int conferenceID)
        {
            if (dbConnection.OpenConnection()) // Open the DB connection from DBConnection
            {
                foreach (int sessionID in selectedSessionIDs)
                {
                    string query = @"
                        INSERT INTO participants_table (userID, sessionID, conferenceID, registrationDate)
                        VALUES (@UserID, @SessionID, @ConferenceID, @RegistrationDate)";

                    MySqlCommand command = new MySqlCommand(query, dbConnection.GetConnection());
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@SessionID", sessionID);
                    command.Parameters.AddWithValue("@ConferenceID", conferenceID); // Add conferenceID
                    command.Parameters.AddWithValue("@RegistrationDate", DateTime.Now);

                    // Execute the query
                    command.ExecuteNonQuery();
                }

                dbConnection.CloseConnection(); // Close the connection from DBConnection
            }
        }
    }

    // Class to represent a session item
    public class SessionItem
    {
        public int SessionID { get; set; }
        public string SessionTitle { get; set; }    
        public int ConferenceID { get; set; }  // Add this property to store the conferenceID
        public string ConferenceName { get; set; }
        public DateTime ConferenceDate { get; set; }
        public string Speaker { get; set; }
    }
}
