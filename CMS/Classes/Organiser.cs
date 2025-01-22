using DatabaseLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Classes
{
    internal class Organiser : User
    {
        private DBConnection connection;

        public Organiser()
        {
            this.connection = new DBConnection();
        }

        public void sayHello()
        {
            Console.WriteLine("Hello World");
        }
    }
}
