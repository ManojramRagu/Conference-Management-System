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
        public EditConference()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageConferenceUI manageConference = new ManageConferenceUI();
            manageConference.Show();
            this.Hide();
        }
    }
}
