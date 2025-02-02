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
            string userName = speakerUserName.Text.Trim();
            string password = speakerPassword.Text.Trim();
            
            // Validations
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(bio) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phoneText) ||
                string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all details.");
                return;
            }

            if (!name.All(char.IsLetter))
            {
                MessageBox.Show("Name must only have letters.");
                return;
            }

            if (!long.TryParse(phoneText, out long phone) || phoneText.Length != 10)
            {
                MessageBox.Show("Please enter a 10 digit phone number.");
                return;
            }

            Speaker speaker = new Speaker();
            User user = new User();
            user.AddUser(userName, password, "Speaker");
            int userId = user.GetUsers(userName);
            speaker.AddSpeaker(name, bio, email, (int)phone, userId);

            ManageSpeaker manageSpeakers = new ManageSpeaker();
            manageSpeakers.Show();
            this.Close();
        }


        private void AddNewSpeaker_Load(object sender, EventArgs e)
        {

        }
    }
}
