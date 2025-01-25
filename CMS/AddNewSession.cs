using CMS.Classes;
using DatabaseLearning;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class AddNewSession : Form
    {
        private Session session;
        private DBConnection connection = new DBConnection();

        // Load Conferences into dropdown
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
            string query = "SELECT userID, fullName FROM users_table WHERE account_type = 'Speaker'";

            try
            {
                if (connection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    speakerDropdown.DataSource = dt;
                    speakerDropdown.DisplayMember = "fullName";
                    speakerDropdown.ValueMember = "userID";
                    speakerDropdown.SelectedIndex = -1;

                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading speakers: " + ex.Message);
            }
        }
        public AddNewSession()
        {
            InitializeComponent();
            session = new Session();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Go Back Button
        private void button2_Click(object sender, EventArgs e)
        {
            ManageSession manageSession = new ManageSession();
            manageSession.Show();
            this.Hide();
        }

        //Create Session Button
        private void button1_Click(object sender, EventArgs e)
        {
            int conferenceID = Convert.ToInt32(conferenceDropdown.SelectedValue);
            string sessionTitle = sessionNameTxt.Text;
            string sessionDescription = description.Text;
            DateTime sessionDate = date.Value;
            string speaker = speakerDropdown.SelectedValue?.ToString();
            string Venue = venue.Text;
            DateTime StartTime = startTime.Value;
            DateTime EndTime = endTime.Value;

            if (string.IsNullOrEmpty(sessionTitle) || string.IsNullOrEmpty(sessionDescription) || string.IsNullOrEmpty(Venue))
            {
                MessageBox.Show("Please fill in all required fields (Session Title, Description, Venue).");
                return;
            }

            if (conferenceDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a conference.");
                return;
            }

            if (speakerDropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a speaker.");
                return;
            }

            Session session = new Session();
            session.CreateSession(sessionTitle, sessionDescription, conferenceID, conferenceDropdown.Text, sessionDate, speaker, Venue, StartTime, EndTime);

            MessageBox.Show("Session created successfully!");
        }

        private void AddNewSession_Load(object sender, EventArgs e)
        {
            LoadConferences();
            LoadSpeakers();
        }
    }
}
