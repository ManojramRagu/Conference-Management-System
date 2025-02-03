using DatabaseLearning;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlX.XDevAPI;

namespace CMS.Classes
{
    public class PRegistration
    {
        private DBConnection connection;

        public int RegID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int ConferenceId { get; set; }
        public int SessionID { get; set; }

        public string ConferenceName { get; set; }
        public string SessionTitle { get; set; }
        public string Venue { get; set; }
        public string SpeakerName { get; set; }

        public PRegistration()
        {
            connection = new DBConnection();
        }

        public PRegistration(int regID, int userID, DateTime date, DateTime time, int conferenceId, int sessionID)
        {
            RegID = regID;
            UserID = userID;
            Date = date;
            Time = time;
            ConferenceId = conferenceId;
            SessionID = sessionID;
        }

        //CREATE REGISTRATION
        public void Register(int userID, int conferenceID, int sessionID)
        {
            string checkQuery = $@"SELECT COUNT(*) FROM registrations_table 
                               WHERE userID = '{userID}' AND sessionID = '{sessionID}'";

            try
            {
                if (connection.OpenConnection())
                {
                    // Check if the user is already registered
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection.GetConnection());
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Already registered for this session.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        connection.CloseConnection();
                        return;
                    }

                    // Continues if not registered
                    string query = $@"INSERT INTO registrations_table 
                                  (userID, date, time, conferenceID, sessionID) 
                                  VALUES 
                                  ('{userID}', 
                                   '{DateTime.Now.ToString("yyyy-MM-dd")}', 
                                   '{DateTime.Now.ToString("HH:mm:ss")}', 
                                   '{conferenceID}', 
                                   '{sessionID}')";

                    MySqlCommand insertCmd = new MySqlCommand(query, connection.GetConnection());
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully registered for the session!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public void EditRegistration(int regID, int userID, int conferenceID, int sessionID)
        {
            string query = $@"UPDATE registrations_table 
                    SET 
                        userID = '{userID}', 
                        conferenceID = '{conferenceID}', 
                        sessionID = '{sessionID}' 
                    WHERE 
                        regID = '{regID}'";
            try
            {
                connection.OpenConnection();
                connection.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.CloseConnection();
            }
        }

        public List<PRegistration> GetRegistrations()
        {
            List<PRegistration> registrations = new List<PRegistration>();
            string query = @"SELECT r.regID, r.date, r.time, s.sessionTitle, c.name AS conferenceName, c.venue, sp.name
                     FROM registrations_table r
                     JOIN sessions_table s ON r.sessionID = s.sessionID
                     JOIN conferences_table c ON r.conferenceId = c.conferenceID
                     JOIN session_speakers ss ON r.sessionID = ss.sessionID
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
                                PRegistration registration = new PRegistration
                                {
                                    RegID = reader.GetInt32("regID"),
                                    Date = reader.GetDateTime("date"),
                                    Time = DateTime.Parse(reader["time"].ToString()),
                                    SessionTitle = reader["sessionTitle"].ToString(),
                                    SpeakerName = reader["name"].ToString(),
                                    ConferenceName = reader["conferenceName"].ToString(),
                                    Venue = reader["venue"].ToString()
                                };

                                registrations.Add(registration);
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

            return registrations;

        }

        // DELETE REGISTRATION
        public void Unregister(int regID)
        {
            string query = $@"DELETE FROM registrations_table WHERE regID = '{regID}'";
            try
            {
                //connection.OpenConnection();
                connection.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
