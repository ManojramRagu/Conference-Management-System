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
        //User user = new User();
        //private Participant participant;
        private int userID;

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
            participantsViewGrid.Columns["SpeakerID"].Visible = false;
            participantsViewGrid.Columns["SpeakerName"].Visible = false;
            participantsViewGrid.Columns["SessionID"].Visible = false;
            participantsViewGrid.Columns["ConferenceID"].Visible = false;
            participantsViewGrid.Columns["SessionTime"].Visible = false;
        }

        private void participantsViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int conferenceID = Convert.ToInt32(participantsViewGrid.SelectedRows[0].Cells["ConferenceID"].Value);
            int sessionID = Convert.ToInt32(participantsViewGrid.SelectedRows[0].Cells["SessionID"].Value);
            Participant participant = new Participant();
            participant.RegisterForConference(userID, conferenceID, sessionID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParticipantUI participantUI = new ParticipantUI(userID);
            participantUI.Show();
            this.Hide();
        }
    }
}
