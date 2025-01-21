using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    internal class Participant : User
    {
        public List<string> RegisteredSessions { get; set; }

        public Participant()
        {
            RegisteredSessions = new List<string>();
        }

        public void RegisterSession(string sessionName)
        {
            RegisteredSessions.Add(sessionName);
        }
    }
}
