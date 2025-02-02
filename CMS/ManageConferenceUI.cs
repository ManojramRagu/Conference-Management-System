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
    public partial class ManageConferenceUI : Form
    {
        Conference conference = new Conference();
        public ManageConferenceUI()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int conferenceId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this conference?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    conference.DeleteConference(conferenceId);
                    List<Conference> conferencesList = conference.GetAllConferences();
                    dataGridView1.DataSource = conferencesList;
                }
            }
            else
            {
                MessageBox.Show("Please select a conference to delete.", "No Selection", MessageBoxButtons.OK);
            }
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            AddNewConference addNewConference = new AddNewConference();
            addNewConference.Show();
            this.Close();
        }

        private void managebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a conference to edit.");
                return;
            }
            int conferenceId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ConferenceId"].Value);

            EditConference editForm = new EditConference(conferenceId);
            editForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrganiserUI organiser = new OrganiserUI();
            organiser.Show();
            this.Close();
        }

        private void ManageConferenceUI_Load(object sender, EventArgs e)
        {            
            List<Conference> conferencesList = conference.GetAllConferences();
            dataGridView1.DataSource = conferencesList;
            dataGridView1.Columns["ConferenceID"].Visible = false;
        }
    }
}
