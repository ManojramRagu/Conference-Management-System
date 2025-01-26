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
        public EditSession(int id)
        {
            InitializeComponent();
            sessionId = id;
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

                conferenceDropdown.SelectedValue = currentSession.ConferenceID;

                speakerDropdown.SelectedValue = currentSession.SpeakerID;

                startTime.Value = currentSession.StartTime;
                endTime.Value = currentSession.EndTime;
            }
            else
            {
                MessageBox.Show("Session not found.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageSession manageSession = new ManageSession();
            manageSession.Show();
            this.Hide();
        }

        private void EditSession_Load(object sender, EventArgs e)
        {
            LoadConferences();
            LoadSpeakers();

            if (sessionId > 0)
            {
                LoadSessionData(sessionId);
            }
            else
            {
                MessageBox.Show("No session selected. Please select a session from the list.");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SessionName = sessionName.Text;
            int conferenceID = (int)conferenceDropdown.SelectedValue;
            int speakerID = (int)speakerDropdown.SelectedValue;
            string sessionDescription = description.Text;
            DateTime StartTime = startTime.Value;
            DateTime EndTime = endTime.Value;

            session.EditSession(sessionId, SessionName, conferenceID, speakerID, sessionDescription, StartTime, EndTime);
        }
    }
}
