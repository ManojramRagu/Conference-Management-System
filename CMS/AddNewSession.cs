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

        private void LoadConferences()
        {
            string query = "SELECT conferenceID, name, venue FROM conferences_table";

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
                    conferenceDropdown.SelectedIndex = -1; // Ensures nothing is selected initially

                    venue.Text = ""; // Ensure venue textbox is empty when the form loads

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

        public AddNewSession()
        {
            InitializeComponent();
            session = new Session();

            //Load the Venue of selected Conference
            conferenceDropdown.SelectedIndexChanged += (sender, e) =>
            {
                if (conferenceDropdown.SelectedIndex != -1)
                {
                    DataRowView selectedRow = conferenceDropdown.SelectedItem as DataRowView;
                    if (selectedRow != null)
                    {
                        venue.Text = selectedRow["venue"].ToString();
                    }
                }
                else
                {
                    venue.Text = "";
                }
            };

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Go Back Button
        private void button2_Click(object sender, EventArgs e)
        {
            ManageSession manageSession = new ManageSession();
            manageSession.Show();
            this.Close();
        }

        //Create Session Button
        private void button1_Click(object sender, EventArgs e)
        {
            int conferenceID = Convert.ToInt32(conferenceDropdown.SelectedValue);
            string sessionTitle = sessionNameTxt.Text;
            string sessionDescription = description.Text;
            string Venue = venue.Text;
            DateTime StartTime = startTime.Value;
            DateTime EndTime = endTime.Value;
            int speakerID = Convert.ToInt32(speakerDropdown.SelectedValue);
            string conferenceName = conferenceDropdown.Text;

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

            // Create session using the corrected method
            session.CreateSession(sessionTitle, sessionDescription, conferenceID, Venue, StartTime, EndTime, speakerID);
            string query = $@"INSERT INTO session_speakers 
            (sessionID, speakerID) 
            VALUES 
            (LAST_INSERT_ID(), '{speakerID}');";
            connection.ExecuteQuery(query);

            ManageSession manageSession = new ManageSession();
            manageSession.Show();
            this.Close();
        }

        private void AddNewSession_Load(object sender, EventArgs e)
        {
            LoadConferences();
            LoadSpeakers();
        }
    }
}
