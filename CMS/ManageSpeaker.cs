﻿using CMS.Classes;
using MySqlX.XDevAPI;
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
    public partial class ManageSpeaker : Form
    {
        Speaker speaker = new Speaker();
        public ManageSpeaker()
        {
            InitializeComponent();
        }

        private void AddNewSpeakerbtn_Click(object sender, EventArgs e)
        {
            AddNewSpeaker addNewSpeaker = new AddNewSpeaker();
            addNewSpeaker.Show();
            this.Hide();
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int speakerID = (int)dataGridView1.SelectedRows[0].Cells["SpeakerID"].Value;

                EditSpeakerDetails editSpeakerDetails = new EditSpeakerDetails(speakerID);
                editSpeakerDetails.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a speaker to edit.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrganiserUI organiser = new OrganiserUI();
            organiser.Show();
            this.Hide();
        }

        private void ManageSpeaker_Load(object sender, EventArgs e)
        {
            List<Speaker> speakersList = speaker.GetSpeakers();
            dataGridView1.DataSource = speakersList;
            dataGridView1.Columns["SpeakerID"].Visible = false;
            dataGridView1.Columns["UserID"].Visible = false;
            dataGridView1.Columns["UserName"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["AccountType"].Visible = false;
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int speakerId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SpeakerID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this speaker?", "Confirm Deletion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    speaker.DeleteSpeaker(speakerId);
                    List<Speaker> speakersList = speaker.GetSpeakers();
                    dataGridView1.DataSource = speakersList;
                }
            }
            else
            {
                MessageBox.Show("Please select a speaker to delete.", "No Selection", MessageBoxButtons.OK);
            }
        }
    }
}
