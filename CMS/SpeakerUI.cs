using CMS.Classes;
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
        public SpeakerUI(int loggedInUserId)
        {
            InitializeComponent();
            speakerUserId = loggedInUserId;
        }

        private void SpeakerUI_Load(object sender, EventArgs e)
        {
            try
            {
                Speaker speaker = new Speaker();
                List<string> Sessions = speaker.GetAssignedSessions(speakerUserId);

                listBox1.Items.Clear();

                foreach (var session in Sessions)
                {
                    listBox1.Items.Add(session);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
