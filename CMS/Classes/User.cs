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
            UserID = userID;
            UserName = userName;
            Password = password;
            AccountType = accountType;
        }

        public User()
        {
            connection = new DBConnection();
        }

        // Method to add user to the database
        public void AddUser(int userID, string userName, string password, string accountType)
        {
            string query = $"INSERT INTO users_table (userID, userName, password, accountType) VALUES ('{userID}', '{userName}', '{password}', '{accountType}');";
            connection.ExecuteQuery(query); // writes the data to the respective table in the database
        }

        // Method to register user
        public void RegisterUser(string userName, string password, string confirmPassword, string accountType)
        {
            if (password == confirmPassword)  // Check if passwords match
            {
                if (!IsUsernameExists(userName))
                {
                    AddUser(UserID, userName, password, accountType);
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
                                    AccountType = reader["accountType"].ToString()
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
    }
}


//TODO  

// make the registration process to store the account type of the user 
// make the login such that it checks for the account type of the user and redirects to the respective page
// add account type to database
// update registration ui to take in the account type
