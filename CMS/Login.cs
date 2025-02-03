using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            var loginResult = user.Login(username, password);

            int loggedInUserID = loginResult.Item1;
            string accountType = loginResult.Item2;

            if (accountType != null)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect based on account type
                switch (accountType)
                {
                    case "Participant":
                        ParticipantUI participantUI = new ParticipantUI(loggedInUserID);
                        participantUI.Show();
                        break;

                    case "Organizer":
                        OrganiserUI organizerUI = new OrganiserUI();
                        organizerUI.Show();
                        break;

                    case "Speaker":
                        SpeakerUI speakerUI = new SpeakerUI(loggedInUserID);
                        speakerUI.Show();
                        break;

                    default:
                        MessageBox.Show("Unknown account type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }


                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationUI registrationUI = new RegistrationUI();
            registrationUI.Show();
            this.Hide();
        }
    }
}
