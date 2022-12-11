using System;
using System.Collections.Generic;
using System.Data.Linq;
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

        public int Id 
        {
            get
            {
                return this.id;
            } 
            set 
            { 
                this.id = value;
            } 
        }
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public string PrivateNotes
        {
            get
            {
                return this.privateNotes;
            }
            set
            {
                this.privateNotes = value;
            }
        }
    }
}
