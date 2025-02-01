using CMS.Classes;
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
    public partial class AddNewSpeaker : Form
    {
        public AddNewSpeaker()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageSpeaker manageSpeaker = new ManageSpeaker();
            manageSpeaker.Show();
            this.Close();
        }

        private void CreateSpeakerButton_Click(object sender, EventArgs e)
        {
            string name = SpeakerNameTxt.Text.Trim();
            string bio = SpeakerBioTxt.Text.Trim();
            string email = SpeakerEmailTxt.Text.Trim();
            string phoneText = SpeakerPhoneTxt.Text.Trim();

            // Check if any field is empty
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(bio) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneText))
            {
                MessageBox.Show("All fields are required. Please fill in all details.");
                return;
            }

            int phone;
            if (int.TryParse(phoneText, out phone))
            {
                Speaker speaker = new Speaker();
                User user = new User();
                user.AddUser(name, "admin", "Speaker");
                int userId = user.GetUsers(name); //Polymorphism
                speaker.AddSpeaker(name, bio, email, phone, userId);

                ManageSpeaker manageSpeakers = new ManageSpeaker();
                manageSpeakers.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number.");
            }
        }
    }
}
