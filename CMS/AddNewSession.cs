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
    public partial class AddNewSession : Form
    {
        private Session session;
        public AddNewSession()
        {
            InitializeComponent();
            session = new Session();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Go Back Button
        private void button2_Click(object sender, EventArgs e)
        {
            ManageSession manageSession = new ManageSession();
            manageSession.Show();
            this.Hide();
        }

        //Create Session Button
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
