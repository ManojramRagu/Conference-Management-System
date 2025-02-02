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
    public partial class ParticipantUI : Form
    {
        PRegistration PRegistration = new PRegistration();

        private int speakerUserId;
        //private int RegID;
        public ParticipantUI(int loggedInUserId)
        {
            InitializeComponent();
            speakerUserId = loggedInUserId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (speakerUserId != null)
            {
                ViewAndRegister participantViewAndRegisterUI = new ViewAndRegister(speakerUserId);
                this.Hide();
                participantViewAndRegisterUI.Show();
            }
            else
            {
                MessageBox.Show("User ID is not set.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageRegisteredSessions manageRegisteredSessionsUI = new ManageRegisteredSessions(speakerUserId);
            manageRegisteredSessionsUI.Show();
            this.Close();
        }
    }
}
