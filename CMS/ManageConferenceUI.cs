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
        public ManageConferenceUI()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            AddNewConference addNewConference = new AddNewConference();
            addNewConference.Show();
            this.Hide();
        }

        private void managebtn_Click(object sender, EventArgs e)
        {
            EditConference editConference = new EditConference();
            editConference.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrganiserUI organiser = new OrganiserUI();
            organiser.Show();
            this.Hide();
        }

        private void ManageConferenceUI_Load(object sender, EventArgs e)
        {
            Conference conference = new Conference();
            List<Conference> conferencesList = conference.GetAllConferences();
            dataGridView1.DataSource = conferencesList;
        }
    }
}
