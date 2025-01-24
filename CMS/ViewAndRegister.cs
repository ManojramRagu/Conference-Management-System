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
        private Participant participant;
        private int userID;  // Assume this is set based on the logged-in user

        // Constructor where logged-in userID is passed
        public ViewAndRegister(int loggedInUserID)
        {
            InitializeComponent();
            participant = new Participant(); // Initialize the Participant class
            userID = loggedInUserID; // Set the logged-in user ID
            LoadSessions(); // Load available sessions when the form loads
        }

        // Method to load available sessions into the ListBox
        private void LoadSessions()
        {
            List<SessionItem> sessions = participant.GetSessions(); // Fetch sessions
            listBox1.DataSource = sessions; // Bind the sessions to the ListBox
        }

        // Register button click event handler
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get the selected session IDs from the ListBox
            var selectedSessions = new List<int>();

            // Loop through the selected items in the ListBox and add the sessionID to the list
            foreach (var item in listBox1.SelectedItems)
            {
                var sessionItem = (SessionItem)item;
                selectedSessions.Add(sessionItem.SessionID);
            }

            // Check if any sessions were selected
            if (selectedSessions.Count == 0)
            {
                MessageBox.Show("Please select at least one session to register.");
                return;
            }

            // Assuming we get the conferenceID from the first selected session
            int conferenceID = 0;
            if (selectedSessions.Count > 0)
            {
                var selectedSessionItem = (SessionItem)listBox1.SelectedItems[0];
                conferenceID = selectedSessionItem.ConferenceID;
            }

            // Register the user for the selected sessions
            try
            {
                participant.RegisterUserForSessions(userID, selectedSessions, conferenceID);
                MessageBox.Show("You have been successfully registered for the selected sessions.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while registering: " + ex.Message);
            }

            // Clear the selection in the ListBox
            listBox1.ClearSelected();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method can be used for additional behavior when the selection changes.
        }

        private void ViewAndRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
