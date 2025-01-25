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
    public partial class ManageSession : Form
    {
        public ManageSession()
        {
            InitializeComponent();
        }

        private void ManageSession_Load(object sender, EventArgs e)
        {

        }

        private void AddSessionButton_Click(object sender, EventArgs e)
        {
            AddNewSession addNewSession = new AddNewSession();
            addNewSession.Show();
            this.Hide();
        }

        private void EditSessionButton_Click(object sender, EventArgs e)
        {
            EditSession editSession = new EditSession();
            editSession.Show();
            this.Hide();
        }
    }
}
