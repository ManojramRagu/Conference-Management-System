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
        //public string FullName { get; set; }
        //public string Email { get; set; }
        public string Password { get; set; }

        // Constructor
        public User(int userID, string userName, string password)
        {
            UserID = userID;
            UserName = userName;
            //FullName = fullName;
            //Email = email;
            Password = password;
        }

        // Methods
        public bool Login(string enteredUserName, string enteredPassword)
        {
            // Compares the entered username and password with stored values
            return UserName == enteredUserName && Password == enteredPassword;
        }

        public void Logout()
        {
            // Logic to handle logout, e.g., clear session
            Console.WriteLine("Logged out successfully.");
        }

        public User()
        {
            connection = new DBConnection();
        }

        public void AddUser(int userID, string userName, string password)
        {
            string query = $"INSERT INTO users_table (userID, userName, password)\r\nVALUES ('{userID}', '{userName}', '{password}');\r\n";
            connection.ExecuteQuery(query); // writes the data to the respective table in the database
        }

        public void RegisterUser(string userName, string password)
        {
            if (!IsUsernameExists(userName))
            {
                AddUser(UserID, userName, password);
            }
            else
            {
                MessageBox.Show("Username already exits. Try a different username.");
            }
        }

        public bool IsUsernameExists(string userNameToCheck)
        {
            // Get the list of users from the database
            List<User> users = GetUsers();

            // Check if the username exists using LINQ
            return users.Any(user => user.UserName.Equals(userNameToCheck, StringComparison.OrdinalIgnoreCase));
        }

        public List<User> GetUsers() 
        {
            List <User> users = new List<User>();
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
                                    //FullName = reader["fullName"].ToString(),
                                    //Email = reader["email"].ToString(),
                                    Password = reader["password"].ToString()
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
                MessageBox.Show($"Error: {ex}");
            }

            return users;
        }
    }
}
