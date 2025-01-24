using System;
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
            //Application.Run(new Registration());
            //Application.Run(new User());
<<<<<<< HEAD
            //Application.Run(new Login())
            Application.Run(new Login());
=======
            //Application.Run(new Login());
            Application.Run(new OrganiserUI());
>>>>>>> 45f335bf52e40e70db78cdabf2355e5f8641149b
        }
    }
}
