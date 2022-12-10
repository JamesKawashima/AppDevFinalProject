using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSO_App_Dev_Project
{
    public class User
    {
        private int id;
        private string username;
        private string firstName;
        private string lastName;
        private string privateNotes;

        public User(int id, string username, string firstName, string lastName, string privateNotes) 
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            PrivateNotes = privateNotes;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrivateNotes { get; set; }
    }
}
