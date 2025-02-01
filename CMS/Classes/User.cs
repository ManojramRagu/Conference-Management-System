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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMS
{
    internal class User
    {
        private DBConnection connection;

        // Attributes
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }

        // Constructor
        public User(int userID, string userName, string password, string accountType)
        {
            //UserID = userID;
            UserName = userName;
            Password = password;
            AccountType = accountType;
        }

        public User()
        {
            connection = new DBConnection();
        }

        // Method to add user to the database
        public void AddUser(string userName, string password, string account_type)
        {
            string query = $"INSERT INTO users_table (userName, password, account_type) VALUES ('{userName}', '{password}', '{account_type}');";
            connection.ExecuteQuery(query); // writes the data to the respective table in the database
        }

        //public int GetUserID(string username)
        //{ 
        //    string query = $"SELECT userID FROM users_table WHERE userName = '{username}'";

        //    //return connection.ExecuteQuery(query);

        //    if (connection.OpenConnection())
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
        //        {
        //            using (MySqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    return Convert.ToInt32(reader["userID"]);
        //                } else { return -1; }
        //            }
        //        }
        //    } else
        //    {
        //        return -1;
        //    }
        //}

        // Method to register user
        public void RegisterUser(string userName, string password, string confirmPassword, string account_type)
        {
            if (password == confirmPassword)  // Check if passwords match
            {
                if (!IsUsernameExists(userName))
                {
                    AddUser(userName, password, account_type);
                    MessageBox.Show("Successfully registered!");
                }
                else
                {
                    MessageBox.Show("Username already exists. Try a different username.");
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

        // Login feature
        public Tuple<int, string> Login(string userName, string password)
        {
            int loggedInUserId = -1;
            string accountType = null;
            string query = $"SELECT userID, account_type FROM users_table WHERE userName = '{userName}' AND password = '{password}'";

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
                                loggedInUserId = Convert.ToInt32(reader["userID"]);
                                accountType = reader["account_type"].ToString();
                                Console.WriteLine($"Successful login for user: {userName}, Account Type: {accountType}, userID: {loggedInUserId}");
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

            return new Tuple<int, string>(loggedInUserId, accountType);
        }


        // Check if the username already exists
        public bool IsUsernameExists(string userNameToCheck)
        {
            List<User> users = GetUsers();
            return users.Any(user => user.UserName.Equals(userNameToCheck, StringComparison.OrdinalIgnoreCase));
        }

        // Get the list of users from the database
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            string query = "SELECT * FROM users_table";

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
                                User user = new User
                                {
                                    UserID = Convert.ToInt32(reader["userID"]),
                                    UserName = reader["userName"].ToString(),
                                    Password = reader["password"].ToString(),
                                    AccountType = reader["account_type"].ToString()
                                };

                                users.Add(user);
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

            return users;
        }

        //Polymosphism via method overloading
        public int GetUsers(string username)
        {
            string query = $"SELECT userID FROM users_table WHERE userName = '{username}'";

            //return connection.ExecuteQuery(query);

            if (connection.OpenConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection()))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["userID"]);
                        }
                        else { return -1; }
                    }
                }
            }
            else
            {
                return -1;
            }
        }

        // Method to get the UserID based on the username
        public int GetLoginId(string userName)
        {
            int loggedInUserID = -1; // Default value indicating no match
            string query = $"SELECT userID FROM users_table WHERE userName = '{userName}'";

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
                                loggedInUserID = Convert.ToInt32(reader["userID"]);
                            }
                        }
                    }
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return loggedInUserID;
        }

    }
}


//TODO  

// make the registration process to store the account type of the user 
// make the login such that it checks for the account type of the user and redirects to the respective page
// add account type to database
// update registration ui to take in the account type
