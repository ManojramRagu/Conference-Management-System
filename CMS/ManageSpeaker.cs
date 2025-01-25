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
    }
}
