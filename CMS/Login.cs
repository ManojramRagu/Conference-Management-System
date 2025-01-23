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
            string accountType = user.Login(username, password);

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

                    //case "Organizer":
                    //    OrganizerUI organizerUI = new OrganizerUI();
                    //    organizerUI.Show();
                    //    break;

                    //case "Speaker":
                    //    SpeakerUI speakerUI = new SpeakerUI();
                    //    speakerUI.Show();
                    //    break;

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
    }
}
