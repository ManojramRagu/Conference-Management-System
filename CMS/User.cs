using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    internal class User
    {
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
    }
}
