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

            User user = new User();
            var loginResult = user.Login(username, password);

            int loggedInUserID = loginResult.Item1;
            string accountType = loginResult.Item2;

            if (accountType != null)
            {
                MessageBox.Show("Login successful!");

                // Redirect based on account type
                switch (accountType)
                {
                    case "Participant":
                        ParticipantUI participantUI = new ParticipantUI();
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
                        MessageBox.Show("Unknown account type.");
                        break;
                }


                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
