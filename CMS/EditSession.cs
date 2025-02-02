using CMS.Classes;
using DatabaseLearning;
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

namespace CMS
{
    public partial class EditSession : Form
    {
        private int sessionId {  get; set; }
        private DBConnection connection = new DBConnection();
        Session session = new Session();
        private string oldSessionName, oldSessionDescription;
        private DateTime oldStartTime, oldEndTime;
        private int oldConferenceID, oldSpeakerID;

        public EditSession(int id)
        {
            InitializeComponent();
            sessionId = id;
        }
        private bool CheckSessionChange()
        {
            string newSessionName = sessionName.Text.Trim();
            string newSessionDescription = description.Text.Trim();
            DateTime newStartTime = startTime.Value;
            DateTime newEndTime = endTime.Value;
            int newConferenceID = (int)conferenceDropdown.SelectedValue;
            int newSpeakerID = (int)speakerDropdown.SelectedValue;

            bool isUpdated = false;

            if (newSessionName != oldSessionName)
            {
                session.SessionTitle = newSessionName;
                isUpdated = true;
            }
            if (newSessionDescription != oldSessionDescription)
            {
                session.SessionDescription = newSessionDescription;
                isUpdated = true;
            }
            if (newStartTime != oldStartTime)
            {
                session.StartTime = newStartTime;
                isUpdated = true;
            }
            if (newEndTime != oldEndTime)
            {
                session.EndTime = newEndTime;
                isUpdated = true;
            }
            if (newConferenceID != oldConferenceID)
            {
                session.ConferenceID = newConferenceID;
                isUpdated = true;
            }
            if (newSpeakerID != oldSpeakerID)
            {
                session.SpeakerID = newSpeakerID;
                isUpdated = true;
            }

            return isUpdated;
        }

        private void LoadConferences()
        {
            string query = "SELECT conferenceID, name FROM conferences_table";

            try
            {
                if (connection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    conferenceDropdown.DataSource = dt;
                    conferenceDropdown.DisplayMember = "name";
                    conferenceDropdown.ValueMember = "conferenceID";
                    conferenceDropdown.SelectedIndex = -1;

                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading conferences: " + ex.Message);
            }
        }

        // Load Speakers into dropdown
        private void LoadSpeakers()
        {
            string query = "SELECT speakersID, name FROM speakers_table";

            try
            {
                if (connection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    speakerDropdown.DataSource = dt;
                    speakerDropdown.DisplayMember = "name";
                    speakerDropdown.ValueMember = "speakersID";
                    speakerDropdown.SelectedIndex = -1;

                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading speakers: " + ex.Message);
            }
        }

        private void LoadSessionData(int sessionId)
        {
            var currentSession = session.GetSessionById(sessionId);

            if (currentSession != null)
            {
                sessionName.Text = currentSession.SessionTitle;
                description.Text = currentSession.SessionDescription;
                startTime.Value = currentSession.StartTime;
                endTime.Value = currentSession.EndTime;

                conferenceDropdown.SelectedValue = currentSession.ConferenceID;
                speakerDropdown.SelectedValue = currentSession.SpeakerID;

                // Store the current values in the 'old' variables for later comparison
                oldSessionName = currentSession.SessionTitle;
                oldSessionDescription = currentSession.SessionDescription;
                oldStartTime = currentSession.StartTime;
                oldEndTime = currentSession.EndTime;
                oldConferenceID = currentSession.ConferenceID;
                oldSpeakerID = currentSession.SpeakerID;
            }
            else
            {
                MessageBox.Show("Session not found.");
                this.Close();
            }
        }

        // Go Back Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckSessionChange())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave unsaved changes?", "Unsaved Changes", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ManageSession manageSession = new ManageSession();
                    manageSession.Show();
                    this.Hide();
                }
            }
            else
            {
                ManageSession manageSession = new ManageSession();
                manageSession.Show();
                this.Hide();
            }
        }

        // Update Button
        private void button1_Click(object sender, EventArgs e)
        {
            string SessionName = sessionName.Text;
            string SessionDescription = description.Text;
            DateTime StartTime = startTime.Value;
            DateTime EndTime = endTime.Value;

            if (string.IsNullOrEmpty(SessionName) || string.IsNullOrEmpty(SessionDescription))
            {
                MessageBox.Show("Session Name and Description are required.");
                return;
            }

            if (conferenceDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a conference.");
                return;
            }
            int ConferenceID = (int)conferenceDropdown.SelectedValue;

            if (speakerDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a speaker.");
                return;
            }
            int SpeakerID = (int)speakerDropdown.SelectedValue;

            if (EndTime <= StartTime || (EndTime - StartTime).TotalMinutes < 30)
            {
                MessageBox.Show("End Time must be greater than 30 minutes from Start Time.");
                endTime.Value = StartTime.AddMinutes(30);
                return;
            }

            if (CheckSessionChange())
            {
                session.EditSession(sessionId, SessionName, ConferenceID, SpeakerID, SessionDescription, StartTime, EndTime);
                MessageBox.Show("Session details updated successfully.");
                this.Close();

                ManageSession manageSession = new ManageSession();
                manageSession.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No changes were made.");
            }
        }


        private void EditSession_Load(object sender, EventArgs e)
        {
            LoadConferences();
            LoadSpeakers();
            LoadSessionData(sessionId);
        }
    }
}
