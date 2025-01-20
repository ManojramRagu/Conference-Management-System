using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS
{
    internal class Session
    {
        // Attributes
        public int SpeakerID { get; set; }
        public string Name { get; set; }

        // Methods
        public void AssignToConference()
        {
            // Logic for assigning the session to a conference
            Console.WriteLine("Session assigned to conference.");
        }

        public void EditDetails()
        {
            // Logic for editing session details
            Console.WriteLine("Session details edited.");
        }
    }
}
