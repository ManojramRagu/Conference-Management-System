﻿using Mysqlx.Prepare;
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

namespace CMS.Classes
{
    internal class Speaker
    {
        public int SpeakerID { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        private DBConnection connection;

        // Constructor
        public Speaker()
        {
            connection = new DBConnection();
        }

        public Speaker(int speakerID, string name, string bio, string email, int phone)
        {
            SpeakerID = speakerID;
            Name = name;
            Bio = bio;
            Email = email;
            Phone = phone;
            connection = new DBConnection();
        }

        // Add speaker
        public void AddSpeaker(int speakerID, string name, string bio, string email, int phone)
        {
            string query = $"INSERT INTO speakers_table (speakerID, name, bio, email, phone) VALUES ('{speakerID}', '{name}', '{bio}', '{email}', '{phone}');";
            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Speaker added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding speaker: {ex.Message}");
            }
        }

        // Get list of speakers
        public List<Speaker> GetSpeakers()
        {
            List<Speaker> speakers = new List<Speaker>();
            string query = "SELECT * FROM speakers_table;";

            try
            {
                if (connection.OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection.GetConnection());
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        speakers.Add(new Speaker
                        {
                            SpeakerID = Convert.ToInt32(reader["speakerID"]),
                            Name = reader["name"].ToString(),
                            Bio = reader["bio"].ToString(),
                            Email = reader["email"].ToString(),
                            Phone = Convert.ToInt32(reader["phone"])
                        });
                    }

                    reader.Close();
                    connection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving speakers: {ex.Message}");
            }

            return speakers;
        }

        // Edit speaker details
        public void EditSpeaker(int speakerID, string newName, string newBio, string newEmail, int newPhone)
        {
            string query = $"UPDATE speakers_table SET name = '{newName}', bio = '{newBio}', email = '{newEmail}', phone = '{newPhone}' WHERE speakerID = '{speakerID}';";
            try
            {
                connection.ExecuteQuery(query);
                MessageBox.Show("Speaker details updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating speaker details: {ex.Message}");
            }
        }

        // Assign speaker to conference
        //public void AssignSpeakerToConference(int speakerID, int conferenceID)
        //{
        //    string query = $"INSERT INTO sessions_table (conferenceID, speakerID) VALUES ('{conferenceID}', '{speakerID}');";
        //    try
        //    {
        //        connection.ExecuteQuery(query);
        //        MessageBox.Show("Speaker assigned to the conference successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error assigning speaker to the conference: {ex.Message}");
        //    }
        //}

        //// Remove speaker from conference
        //public void RemoveSpeakerFromConference(int speakerID, int conferenceID)
        //{
        //    string query = $"DELETE FROM sessions_table WHERE conferenceID = '{conferenceID}' AND speakerID = '{speakerID}';";
        //    try
        //    {
        //        connection.ExecuteQuery(query);
        //        MessageBox.Show("Speaker removed from the conference successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error removing speaker from the conference: {ex.Message}");
        //    }
        //}
    }
}