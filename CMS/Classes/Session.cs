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
        public void CreateSessions(int sessionID, string sessionTitle, string sessionDescription, int conferenceID, string conferenceName, DateTime conferenceDate, string speaker, string venue)
        {
            string query = $@"INSERT INTO sessions_table 
                            (conferenceID, conferenceName, sessionID, sessionTitle, sessionDescription, conferenceDate, speaker, venue) 
                            VALUES
                            ('{conferenceID}', '{conferenceName}', '{sessionID}', '{sessionTitle}', '{sessionDescription}', '{conferenceDate}', '{speaker}', '{venue}');
            ";
            connection.ExecuteQuery(query); // WRITES DATA TO THE DATABASE
        }

        // GET SESSIONS METHOD
        public List<Session> GetSessions()
        {
            List<Session> sessions = new List<Session>();
            string query = "SELECT * FROM sessions_table";

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
                                    SessionTitle = reader["sessionTitle"].ToString(),
                                    SessionDescription = reader["sessionDescription"].ToString(),
                                    ConferenceDate = Convert.ToDateTime(reader["conferenceDate"]),
                                    Speaker = reader["speaker"].ToString(),
                                    Venue = reader["venue"].ToString()
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
            string query = $"DELETE FROM sessions_table WHERE sessionID = '{sessionID}';";
            connection.ExecuteQuery(query);
            MessageBox.Show("Session deleted successfully.");

            //try
            //{
            //    if (connection.OpenConnection())
            //    {
            //        using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
            //        {
            //            cmd.ExecuteNonQuery();
            //        }

            //        connection.CloseConnection();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error: {ex.Message}");
            //}
        }
    }
}