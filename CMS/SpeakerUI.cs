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

        }
    }
}
