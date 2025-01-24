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
        private Conference currentConference;

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
            Conference conference = new Conference();
            currentConference = conference.GetConferenceById(conferenceId);

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
            if (currentConference == null)
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
            if (newName != currentConference.ConferenceName)
            {
                currentConference.ConferenceName = newName;
                isUpdated = true;
            }
            if (newVenue != currentConference.Venue)
            {
                currentConference.Venue = newVenue;
                isUpdated = true;
            }
            if (newDescription != currentConference.Description)
            {
                currentConference.Description = newDescription;
                isUpdated = true;
            }
            if (newDate != currentConference.Date)
            {
                currentConference.Date = newDate;
                isUpdated = true;
            }
            if (newCapacity != currentConference.Capacity)
            {
                currentConference.Capacity = newCapacity;
                isUpdated = true;
            }

            if (isUpdated)
            {
                Conference updatedConference = new Conference();
                updatedConference.EditConference(conferenceId, currentConference.ConferenceName, currentConference.Date, currentConference.Venue, currentConference.Description, currentConference.Capacity);
                MessageBox.Show("Conference details updated successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No changes were made.");
            }
        }
    }
    }
}
