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
    public partial class EditSpeakerDetails : Form
    {
        public EditSpeakerDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageSpeaker manageSpeaker = new ManageSpeaker();
            manageSpeaker.Show();
            this.Hide();
        }
    }
}
