using DatabaseLearning;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CMS.Classes
{
    internal class PRegistration
    {
        private DBConnection connection;

        public int RegID { get; set; }
        public int UserID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public int ConferenceId { get; set; }
        public int SessionID { get; set; }

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

        // CREATE REGISTRATION
        public void Register(int userID, int conferenceID, int sessionID)
        {
            string query = $@"INSERT INTO registrations_table 
            (userID, date, time, conferenceID, sessionID) 
            VALUES 
            ('{userID}', 
             '{DateTime.Now.ToString("yyyy-MM-dd")}', 
             '{DateTime.Now.ToString("HH:mm:ss")}', 
             '{conferenceID}', 
             '{sessionID}')";
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

        // GET REGISTRAIONS METHOD
        public PRegistration GetRegistration(int regID)
        {
            PRegistration registration = null;
            string query = $@"SELECT * FROM registrations_table WHERE regID = {regID}";

            try
            {
                if (connection.OpenConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                registration = new PRegistration
                                {
                                    RegID = Convert.ToInt32(reader["regID"]),
                                    UserID = Convert.ToInt32(reader["userID"]),
                                    ConferenceId = Convert.ToInt32(reader["conferenceID"]),
                                    SessionID = Convert.ToInt32(reader["sessionID"]),
                                    Date = Convert.ToDateTime(reader["date"]),
                                    Time = Convert.ToDateTime(reader["time"])
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

            return registration;
        }

        // DELETE REGISTRATION
        public void Unregister(int regID)
        {
            string query = $@"DELETE FROM registrations_table WHERE regID = '{regID}'";
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
    }
}
