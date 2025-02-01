using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private string oldName, oldVenue, oldDescription;
        private DateTime oldDate;
        private int oldCapacity;

        public EditConference(int id)
        {
            InitializeComponent();
            conferenceId = id;
        }
        // Functions
        private bool CheckConferenceChange()
        {
            // Update only changed fields
            string newName = conferenceName.Text.Trim();
            string newVenue = conferenceVenue.Text.Trim();
            string newDescription = conferenceDescription.Text.Trim();
            DateTime newDate = conferenceDate.Value;
            int newCapacity = (int)conferenceCapacity.Value;

            //if (conferenceName.TextChanged == null) { }

            // Checks for changes
            bool isUpdated = false;

            if (newName != oldName)
            {
                conference.ConferenceName = newName;
                isUpdated = true;
            }
            if (newVenue != oldVenue)
            {
                conference.Venue = newVenue;
                isUpdated = true;
            }
            if (newDescription != oldDescription)
            {
                conference.Description = newDescription;
                isUpdated = true;
            }
            if (newDate != oldDate)
            {
                conference.Date = newDate;
                isUpdated = true;
            }
            if (newCapacity != oldCapacity)
            {
                conference.Capacity = newCapacity;
                isUpdated = true;
            }
            return isUpdated;
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

                oldName = currentConference.ConferenceName;
                oldVenue = currentConference.Venue;
                oldDescription = currentConference.Description;
                oldDate = currentConference.Date;
                oldCapacity = currentConference.Capacity;
            }
            else
            {
                MessageBox.Show("Conference not found.");
                this.Close();
            }
        }

        // Go Back Butoon
        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckConferenceChange())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave unsaved changes?", "Unsaved Changes", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ManageConferenceUI manageConference1 = new ManageConferenceUI();
                    manageConference1.Show();
                    this.Hide();
                }
            }
            else
            {
                ManageConferenceUI manageConference2 = new ManageConferenceUI();
                manageConference2.Show();
                this.Hide();
            }  
        }

        private void conferenceUpdate_Click(object sender, EventArgs e)
        {
            if (conference == null)
            {
                MessageBox.Show("Error loading conference details.");
                return;
            }

            if (CheckConferenceChange())
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

        private void EditConference_Load(object sender, EventArgs e)
        {
            LoadConferenceData(conferenceId);
        }
    }
}