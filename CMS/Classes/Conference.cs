using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Classes
{
    internal class Conference
    {
        public int ConferenceId { get; set; }
        public string ConferenceName { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }

        public void CreateConference(int id, string name, DateTime date, string venue, string description)
        {
            ConferenceId = id;
            ConferenceName = name;
            Date = date;
            Venue = venue;
            Description = description;
            Console.WriteLine("Conference created successfully.");
        }

        // Edit an existing conference
        public void EditConference(string name, DateTime date, string venue, string description)
        {
            ConferenceName = name;
            Date = date;
            Venue = venue;
            Description = description;
            Console.WriteLine("Conference details updated successfully.");
        }

        // Delete the conference
        public void DeleteConference()
        {
            ConferenceId = 0;
            ConferenceName = null;
            Date = DateTime.MinValue;
            Venue = null;
            Description = null;
            Console.WriteLine("Conference deleted successfully.");
        }

        // View conference details
        public void ViewDetails()
        {
        }
    }
}
