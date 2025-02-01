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
        private string oldName, oldBio, oldEmail;
        private int oldPhone;

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
                        SpeakerNameTxt.Text = reader["name"].ToString();
                        SpeakerBioTxt.Text = reader["bio"].ToString();
                        SpeakerEmailTxt.Text = reader["email"].ToString();
                        SpeakerPhoneTxt.Text = reader["phone"].ToString();

                        oldName = reader["name"].ToString();
                        oldBio = reader["bio"].ToString();
                        oldEmail = reader["email"].ToString();
                        oldPhone = int.Parse(reader["phone"].ToString());
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

        // METHOD TO CHECK CHANGDS
        private bool CheckSpeakerChange()
        {
            string newName = SpeakerNameTxt.Text.Trim();
            string newBio = SpeakerBioTxt.Text.Trim();
            string newEmail = SpeakerEmailTxt.Text.Trim();
            int newPhone;

            if (!int.TryParse(SpeakerPhoneTxt.Text.Trim(), out newPhone))
                return false;

            bool isUpdated = false;

            if (newName != oldName) 
            {
                isUpdated = true;
            }
            if (newBio != oldBio)
            {
                isUpdated = true;
            }
            if (newEmail != oldEmail)
            {
                isUpdated = true;
            }
            if (newPhone != oldPhone)
            {
                isUpdated = true;
            }

            return isUpdated;
        }


        //GO BACK BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckSpeakerChange())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave unsaved changes?", "Unsaved Changes", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ManageSpeaker manageSpeaker = new ManageSpeaker();
                    manageSpeaker.Show();
                    this.Close();
                }
            }
            else
            {
                ManageSpeaker manageSpeaker = new ManageSpeaker();
                manageSpeaker.Show();
                this.Close();
            }
        }

        //UPDATE SPEAKER BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckSpeakerChange())
            {
                string newName = SpeakerNameTxt.Text.Trim();
                string newBio = SpeakerBioTxt.Text.Trim();
                string newEmail = SpeakerEmailTxt.Text.Trim();
                int newPhone;

                if (int.TryParse(SpeakerPhoneTxt.Text.Trim(), out newPhone))
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
            else
            {
                MessageBox.Show("No changes were made.");
            }
        }


        private void EditSpeakerDetails_Load(object sender, EventArgs e)
        {
            LoadSpeakerData(speakerID);
        }
    }
}
