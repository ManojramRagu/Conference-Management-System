using CMS.Classes;
using DatabaseLearning;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Data.Common;y
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class ViewAndRegister : Form
    {
        Session session = new Session();
        User user = new User();
        private Participant participant;
        private int userID;  // Assume this is set based on the logged-in user

        // Constructor where logged-in userID is passed
        public ViewAndRegister(int loggedInUserID)
        {
            InitializeComponent();
            //participant = new Participant(); // Initialize the Participant class
            userID = loggedInUserID; // Set the logged-in user ID
            //LoadSessions(); // Load available sessions when the form loads
        }

        // Method to load available sessions into the ListBox
        private void LoadSessions()
        {
            List<Session> sessionList = session.GetSessions();
            participantsViewGrid.DataSource = sessionList;
        }

        // Register button click event handler
        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method can be used for additional behavior when the selection changes.
        }

        private void ViewAndRegister_Load(object sender, EventArgs e)
        {
            LoadSessions();
        }

        private void participantsViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int conferenceID = Convert.ToInt32(participantsViewGrid.SelectedRows[0].Cells["ConferenceID"].Value);
            int sessionID = Convert.ToInt32(participantsViewGrid.SelectedRows[0].Cells["SessionID"].Value);
            Participant participant = new Participant();
            string username = "savi";
            participant.RegisterForConference(userID, conferenceID, sessionID);
            //participant.RegisterForConference(userID, conferenceID, sessionID);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    // Get the selected session IDs from the DataGridView
        //    var selectedSessions = new List<int>();

        //    foreach (DataGridViewRow row in participantsViewGrid.SelectedRows)
        //    {
        //        if (row.DataBoundItem is SessionItem sessionItem)
        //        {
        //            selectedSessions.Add(sessionItem.SessionID);
        //        }
        //    }

        //    // Check if any sessions were selected
        //    if (selectedSessions.Count == 0)
        //    {
        //        MessageBox.Show("Please select at least one session to register.");
        //        return;
        //    }

        //    // Assuming we get the conferenceID from the first selected session
        //    int conferenceID = 0;
        //    if (participantsViewGrid.SelectedRows.Count > 0)
        //    {
        //        var selectedRow = participantsViewGrid.SelectedRows[0];
        //        if (selectedRow.DataBoundItem is SessionItem selectedSessionItem)
        //        {
        //            conferenceID = selectedSessionItem.ConferenceID;
        //        }
        //    }

        //    // Register the user for the selected sessions
        //    try
        //    {
        //        participant.RegisterUserForSessions(userID, selectedSessions, conferenceID);
        //        MessageBox.Show("You have been successfully registered for the selected sessions.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred while registering: " + ex.Message);
        //    }

        //    // Clear the selection in the DataGridView
        //    participantsViewGrid.ClearSelection();
        //}
    }
}
