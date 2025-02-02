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
            // Validating Inputs
            if (string.IsNullOrWhiteSpace(conferenceName.Text))
            {
                MessageBox.Show("Conference Name cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(conferenceVenue.Text))
            {
                MessageBox.Show("Venue cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(conferenceDescription.Text))
            {
                MessageBox.Show("Description cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (conferenceCapacity.Value <= 0)
            {
                MessageBox.Show("Capacity must be greater than zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for Change and call fnction
            if (CheckConferenceChange())
            {
                conference.EditConference(conferenceId, conference.ConferenceName, conference.Date, conference.Venue, conference.Description, conference.Capacity);
                MessageBox.Show("Conference details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                ManageConferenceUI manageConference = new ManageConferenceUI();
                manageConference.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void EditConference_Load(object sender, EventArgs e)
        {
            LoadConferenceData(conferenceId);
        }
    }
}