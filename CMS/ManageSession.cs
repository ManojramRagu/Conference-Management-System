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
    public partial class ManageSession : Form
    {
        Session session = new Session();
        public ManageSession()
        {
            InitializeComponent();
        }

        private void ManageSession_Load(object sender, EventArgs e)
        {
            List<Session> sessionList = session.GetSessions();
            dataGridView1.DataSource = sessionList;

            dataGridView1.Columns["SessionTime"].Visible = false;
            dataGridView1.Columns["SpeakerName"].Visible = false;
            dataGridView1.Columns["SessionID"].Visible = false;
            dataGridView1.Columns["SpeakerID"].Visible = false;
            dataGridView1.Columns["ConferenceID"].Visible = false;

            dataGridView1.Columns["SessionTitle"].DisplayIndex = 0;
            dataGridView1.Columns["ConferenceName"].DisplayIndex = 1;
            dataGridView1.Columns["Speaker"].DisplayIndex = 2;
            dataGridView1.Columns["SessionDescription"].DisplayIndex = 3;
            dataGridView1.Columns["Venue"].DisplayIndex = 4;
            dataGridView1.Columns["ConferenceDate"].DisplayIndex = 5;
            dataGridView1.Columns["StartTime"].DisplayIndex = 6;
            dataGridView1.Columns["EndTime"].DisplayIndex = 7;

            dataGridView1.Columns["StartTime"].DefaultCellStyle.Format = "hh:mm tt";
            dataGridView1.Columns["EndTime"].DefaultCellStyle.Format = "hh:mm tt";
        }

        private void AddSessionButton_Click(object sender, EventArgs e)
        {
            AddNewSession addNewSession = new AddNewSession();
            addNewSession.Show();
            this.Hide();
        }

        private void EditSessionButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to edit.");
                return;
            }
            int sessionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SessionID"].Value);

            EditSession editSession = new EditSession(sessionId);
            editSession.Show();
            this.Hide();
        }

        //Go Back works
        private void button2_Click(object sender, EventArgs e)
        {
            OrganiserUI organiser = new OrganiserUI();
            organiser.Show();
            this.Hide();
        }

        //Remove Session works
        private void RemoveSessionButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int sessionId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SessionID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this session?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    session.DeleteSession(sessionId);
                    List<Session> sessionList = session.GetSessions();
                    dataGridView1.DataSource = sessionList;
                }
            }
            else
            {
                MessageBox.Show("Please select a session to delete.", "No Selection", MessageBoxButtons.OK);
            }
        }
    }
}
