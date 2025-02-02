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
    public partial class AddNewConference : Form
    {
        private Conference conference;
        public AddNewConference()
        {
            InitializeComponent();
            conference = new Conference();
        }

        // Go Back button
        private void button2_Click(object sender, EventArgs e)
        {
            ManageConferenceUI manageConference = new ManageConferenceUI();
            manageConference.Show();
            this.Hide();
        }

        private void createConference_Click(object sender, EventArgs e)
        {
            string name = conferenceName.Text.Trim();
            string venue = conferenceVenue.Text.Trim();
            string description = conferenceDescription.Text.Trim();
            DateTime date = conferenceDate.Value;
            int capacity = (int)conferenceCapacity.Value;

            // Input validations
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(venue) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all the required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (capacity <= 0)
            {
                MessageBox.Show("Please enter a valid capacity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (date.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Please select an upcoming date.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creates new conference if all Inputs are valid
            conference.CreateConference(name, date, venue, description, capacity);

            ManageConferenceUI manageConference = new ManageConferenceUI();
            manageConference.Show();
            this.Close();
        }
    }
}
