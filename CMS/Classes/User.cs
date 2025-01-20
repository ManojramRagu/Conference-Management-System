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

namespace CMS
{
    internal class User
    {
        private DBConnection connection;
        
        // Attributes
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Constructor
        public User(int userID, string userName, string fullName, string email, string password)
        {
            UserID = userID;
            UserName = userName;
            FullName = fullName;
            Email = email;
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

        public void AddUser(int userID, string userName, string fullName, string email, string password)
        {
            string query = $"INSERT INTO user_table (userID, userName, fullName, email, password)\r\nVALUES ('{userID}', '{userName}' , '{fullName}', '{email}', '{password}');\r\n";
            connection.ExecuteQuery(query); // writes the data to the respective table in the database
        }
    }
}
