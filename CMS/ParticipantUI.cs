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

        //private int speakerUserId;
        private int participantUserID;
        public ParticipantUI(int loggedInUserId)
        {
            InitializeComponent();
            participantUserID = loggedInUserId;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAndRegister participantViewAndRegisterUI = new ViewAndRegister(participantUserID);
            this.Hide();
            participantViewAndRegisterUI.Show();

            //participantViewAndRegister.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageRegisteredSessions manageRegisteredSessions = new ManageRegisteredSessions(participantUserID);
            this.Hide();
            manageRegisteredSessions.Show();
        }
    }
}
