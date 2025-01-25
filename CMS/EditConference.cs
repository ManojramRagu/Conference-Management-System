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
    public partial class EditConference : Form
    {
        private int conferenceId;
        Conference conference = new Conference();

        public EditConference(int id)
        {
            InitializeComponent();
            conferenceId = id;
        }
        private void EditConference_Load(object sender, EventArgs e)
        {
            if (conferenceId > 0)
            {
                LoadConferenceData(conferenceId);
            }
            else
            {
                MessageBox.Show("No conference selected. Please select a conference from the list.");
                this.Close();
            }
        }
        private void LoadConferenceData(int conferenceId)
        {
            var currentConference = conference.GetConferenceById(conferenceId);

            if (currentConference != null)
            {
                conferenceName.Text = currentConference.ConferenceName;
                conferenceVenue.Text = currentConference.Venue;
                conferenceDescription.Text = currentConference.Description;
                conferenceDate.Value = currentConference.Date;
                conferenceCapacity.Value = currentConference.Capacity;
            }
            else
            {
                MessageBox.Show("Conference not found.");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageConferenceUI manageConference = new ManageConferenceUI();
            manageConference.Show();
            this.Hide();
        }

        private void conferenceUpdate_Click(object sender, EventArgs e)
        {
            if (conference == null)
            {
                MessageBox.Show("Error loading conference details.");
                return;
            }

            // Compare and update only changed fields
            string newName = conferenceName.Text.Trim();
            string newVenue = conferenceVenue.Text.Trim();
            string newDescription = conferenceDescription.Text.Trim();
            DateTime newDate = conferenceDate.Value;
            int newCapacity = (int)conferenceCapacity.Value;

            // Track changes to update only modified fields
            bool isUpdated = false;
            if (newName != conference.ConferenceName)
            {
                conference.ConferenceName = newName;
                isUpdated = true;
            }
            if (newVenue != conference.Venue)
            {
                conference.Venue = newVenue;
                isUpdated = true;
            }
            if (newDescription != conference.Description)
            {
                conference.Description = newDescription;
                isUpdated = true;
            }
            if (newDate != conference.Date)
            {
                conference.Date = newDate;
                isUpdated = true;
            }
            if (newCapacity != conference.Capacity)
            {
                conference.Capacity = newCapacity;
                isUpdated = true;
            }

            if (isUpdated)
            {
                Conference updatedConference = new Conference();
                updatedConference.EditConference(conferenceId, conference.ConferenceName, conference.Date, conference.Venue, conference.Description, conference.Capacity);
                MessageBox.Show("Conference details updated successfully.");
                this.Close();
                ManageConferenceUI manageConference = new ManageConferenceUI();
                manageConference.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No changes were made.");
            }
        }
    }
}
