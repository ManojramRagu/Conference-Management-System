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
    public partial class SpeakerUI : Form
    {
        private int speakerUserId;
        Speaker speaker = new Speaker();
        public SpeakerUI(int loggedInUserId)
        {
            InitializeComponent();
            speakerUserId = loggedInUserId;
        }

        private void SpeakerUI_Load(object sender, EventArgs e)
        {
            List<Classes.Session> speakersSessionList = speaker.GetAssignedSessions(speakerUserId);
            dataGridView1.DataSource = speakersSessionList;

            // Removing unncessary Columbs
            dataGridView1.Columns["SessionID"].Visible = false;
            dataGridView1.Columns["SessionDescription"].Visible = false;
            dataGridView1.Columns["SpeakerName"].Visible = false;
            dataGridView1.Columns["SpeakerID"].Visible = false;
            dataGridView1.Columns["ConferenceID"].Visible = false;
            dataGridView1.Columns["SessionTime"].Visible = false;
            dataGridView1.Columns["Speaker"].Visible = false;
        }
    }
}
