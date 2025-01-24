using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Prepare;
using System.Configuration;
using System.Data.Common;
using DatabaseLearning;
using System.Data.SqlClient;

namespace CMS
{
    public partial class ViewAndRegister : Form
    {
        public ViewAndRegister()
        {
            InitializeComponent();
        }

        private int loggedInUserID;  // Store the logged-in user's ID

        // Constructor that accepts the logged-in user's ID
        public void RegisterForm(int userID)
        {  // Initialize the UI components
            loggedInUserID = userID;  // Store the logged-in user's ID for use during registration
            LoadSessions();           // Load available sessions into the ListBox
        }

        // Load available sessions into the ListBox
        private void LoadSessions()
        {
            // SQL query to retrieve session details from the sessions_table
            string query = "SELECT sessionID, description FROM sessions_table";

            DBConnection dbConnection = new DBConnection();  // Create a new DBConnection instance

            if (dbConnection.OpenConnection())  // Try to open a connection to the database
            {
                MySqlCommand cmd = new MySqlCommand(query, dbConnection.GetConnection());  // Create a command object with the query
                MySqlDataReader reader = cmd.ExecuteReader();  // Execute the query and get the results

                while (reader.Read())  // Loop through the results
                {
                    // Add each session to the ListBox (display only the description of the session)
                    listBoxSessions.Items.Add(new Session
                    {
                        SessionID = reader.GetInt32("sessionID"),  // Get the sessionID
                        Description = reader.GetString("description")  // Get the session description
                    });
                }

                dbConnection.CloseConnection();  // Close the connection once data is retrieved
            }
            else
            {
                MessageBox.Show("Failed to load sessions.");  // Show an error message if the connection failed
            }
        }

        // Register button click event handler
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (listBoxSessions.SelectedItem != null)  // Check if a session is selected
            {
                // Get the selected session from the ListBox
                Session selectedSession = (Session)listBoxSessions.SelectedItem;
                // Get the conferenceID from the TextBox
                int conferenceID = int.Parse(txtConferenceID.Text);

                // Create an instance of the Participant class to handle registration
                Participant participant = new Participant();

                // Call the RegisterForSession method to register the participant
                bool registrationSuccess = participant.RegisterForSession(loggedInUserID, conferenceID, selectedSession.SessionID);

                if (registrationSuccess)
                {
                    MessageBox.Show("Successfully registered for the session.");  // Show success message
                }
                else
                {
                    MessageBox.Show("Failed to register.");  // Show failure message
                }
            }
            else
            {
                MessageBox.Show("Please select a session to register.");  // Show message if no session is selected
            }
        }

        private void ViewAndRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
