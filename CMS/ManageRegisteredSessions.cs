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
    public partial class ManageRegisteredSessions : Form
    {
        private int userID;  // Assume this is set based on the logged-in user
        PRegistration registration = new PRegistration();

        public ManageRegisteredSessions(int loggedInUserID)
        {
            InitializeComponent();
            userID = loggedInUserID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParticipantUI participantUI = new ParticipantUI(userID);
            participantUI.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int RegID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["RegID"].Value);
            registration.Unregister(RegID);
            MessageBox.Show("Successfully unregistered from session.","Unregistered",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void LoadSession()
        {
            List<PRegistration> registrationList = registration.GetRegistrations();
            dataGridView1.DataSource = registrationList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ManageRegisteredSessions_Load(object sender, EventArgs e)
        {
            LoadSession();
            dataGridView1.Columns["RegID"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["conferenceID"].Visible = false;
            dataGridView1.Columns["SessionID"].Visible = false;
        }
    }
}
