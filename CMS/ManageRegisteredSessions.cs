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
    public partial class ManageRegisteredSessions : Form
    {
        private int userId;
        public ManageRegisteredSessions(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
