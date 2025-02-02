﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());

            //Application.Run(new ManageSession());
            //Application.Run(new OrganiserUI());
            //Application.Run(new ViewAndRegister());
            //Application.Run(new User());
            //Application.Run(new OrganiserUI());
        }
    }
}
