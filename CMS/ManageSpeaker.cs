using CMS.Classes;
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
            EditSpeakerDetails editSpeakerDetails = new EditSpeakerDetails();
            editSpeakerDetails.Show();
            this.Hide();
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
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.Name != "SpeakerID" && column.Name != "Name" && column.Name != "Bio" && column.Name != "Email" && column.Name != "Phone")
                {
                    column.Visible = false;
                }
            }
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
