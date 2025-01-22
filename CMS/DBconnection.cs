using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseLearning
{
    internal class DBConnection
    {
        private MySqlConnection connection;
        public DBConnection()
        {
            string connectionString = "server=localhost;database=cms;user=root;password=;";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        public void ExecuteQuery(string query)
        {
            if (OpenConnection())
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
//this is for testing