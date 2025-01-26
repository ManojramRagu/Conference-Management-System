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
    public partial class EditSpeakerDetails : Form
    {
        private DBConnection connection = new DBConnection();
        private int speakerID;
        public EditSpeakerDetails(int id)
        {
            InitializeComponent();
            speakerID = id;
        }

        // LOAD SELECTED SPEAKERS CURRENT DETAILS
        public void LoadSpeakerData(int speakerID)
        {
            string query = $"SELECT name, bio, email, phone FROM speakers_table WHERE speakersID = {speakerID};";

            try
            {
                if (connection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Populate textboxes with the current speaker's details
                        SpeakerNameTxt.Text = reader["name"].ToString();
                        SpeakerBioTxt.Text = reader["bio"].ToString();
                        SpeakerEmailTxt.Text = reader["email"].ToString();
                        SpeakerPhoneTxt.Text = reader["phone"].ToString();
                    }

                    reader.Close();
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving speaker details: {ex.Message}");
            }
        }
        //GO BACK BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            ManageSpeaker manageSpeaker = new ManageSpeaker();
            manageSpeaker.Show();
            this.Close();
        }

        //UPDATE SPEAKER BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            string newName = SpeakerNameTxt.Text;
            string newBio = SpeakerBioTxt.Text;
            string newEmail = SpeakerEmailTxt.Text;
            int newPhone;

            if (int.TryParse(SpeakerPhoneTxt.Text, out newPhone))
            {
                Speaker speaker = new Speaker();
                speaker.EditSpeaker(speakerID, newName, newBio, newEmail, newPhone);
                ManageSpeaker manageSpeaker = new ManageSpeaker();
                manageSpeaker.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.");
            }
        }

        private void EditSpeakerDetails_Load(object sender, EventArgs e)
        {
            LoadSpeakerData(speakerID);
        }
    }
}
