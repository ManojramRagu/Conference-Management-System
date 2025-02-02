﻿using System;
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
    public partial class OrganiserUI : Form
    {
        public OrganiserUI()
        {
            InitializeComponent();
        }

        private void managebtn_Click(object sender, EventArgs e)
        {
            ManageConferenceUI manageConferenceUI = new ManageConferenceUI();
            manageConferenceUI.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageSession manageSession = new ManageSession();
            manageSession.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageSpeaker manageSpeaker = new ManageSpeaker();
            manageSpeaker.Show();
            this.Hide();
        }

        private void OrganiserUI_Load(object sender, EventArgs e)
        {

        }
    }
}
