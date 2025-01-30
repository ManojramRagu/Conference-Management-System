using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DatabaseLearning;
using System.Data.SqlClient;
using System.Windows.Forms;
using CMS.Classes;

namespace CMS
{
    internal class Participant : User
    {
        //public int UserID { get; set; }
        public string Name { get; set; }

        PRegistration registration = new PRegistration();

        // Register the participant for a conference and session
        public void RegisterForConference(int userID, int conferenceID, int sessionID)
        {
            //PRegistration registration = new PRegistration();
            registration.Register(userID, conferenceID, sessionID);
        }

        // Edit registration details
        public void EditRegistrationDetails(int regID, int conferenceID, int sessionID)
        {
            //PRegistration registration = new PRegistration();
            registration.EditRegistration(regID, UserID, conferenceID, sessionID);
        }

        // Get participant's registration by regID
        public void GetRegistrationDetails(int regID)
        {
            //PRegistration registration = new PRegistration();
            registration.GetRegistration(regID);
        }

        // Unregister the participant
        public void Unregister(int regID)
        {
            //PRegistration registration = new PRegistration();
            registration.Unregister(regID);
        }
    }
}

