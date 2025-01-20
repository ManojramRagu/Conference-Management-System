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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = PasswordBox.Text;
            User newUser = new User(1, "savishkar", "Savishkar Thiruchelvam", "saviskar2003@gmail.com", "savishkar123");
            newUser.Login("savishkar", "savishkar123");
        }
    }
}
