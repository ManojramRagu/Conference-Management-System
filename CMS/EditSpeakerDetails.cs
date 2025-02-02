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
                MessageBox.Show($"Error retrieving speaker details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // METHOD TO CHECK CHANGDS
        private bool CheckSpeakerChange()
        {
            string newName = SpeakerNameTxt.Text.Trim();
            string newBio = SpeakerBioTxt.Text.Trim();
            string newEmail = SpeakerEmailTxt.Text.Trim();
            string newPhoneText = SpeakerPhoneTxt.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newBio) ||
                string.IsNullOrEmpty(newEmail) || string.IsNullOrEmpty(newPhoneText))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate phone number
            if (!int.TryParse(newPhoneText, out int newPhone) || newPhoneText.Length != 10)
            {
                MessageBox.Show("Phone number must be exactly 10 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return (newName != oldName || newBio != oldBio || newEmail != oldEmail || newPhone != oldPhone);
        }



        //GO BACK BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SpeakerNameTxt.Text) ||
                string.IsNullOrWhiteSpace(SpeakerBioTxt.Text) ||
                string.IsNullOrWhiteSpace(SpeakerEmailTxt.Text) ||
                string.IsNullOrWhiteSpace(SpeakerPhoneTxt.Text))
            {
                MessageBox.Show("You cannot leave with empty fields. Please fill all details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CheckSpeakerChange())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave unsaved changes?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            if (!CheckSpeakerChange())
            {
                MessageBox.Show("No Changes Made.");
                return;
            }

            string newName = SpeakerNameTxt.Text.Trim();
            string newBio = SpeakerBioTxt.Text.Trim();
            string newEmail = SpeakerEmailTxt.Text.Trim();
            int newPhone = int.Parse(SpeakerPhoneTxt.Text.Trim());

            Speaker speaker = new Speaker();
            speaker.EditSpeaker(speakerID, newName, newBio, newEmail, newPhone);

            ManageSpeaker manageSpeaker = new ManageSpeaker();
            manageSpeaker.Show();
            this.Close();
        }

        private void EditSpeakerDetails_Load(object sender, EventArgs e)
        {
            LoadSpeakerData(speakerID);
        }
    }
}
