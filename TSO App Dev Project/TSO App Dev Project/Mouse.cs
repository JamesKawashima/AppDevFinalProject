using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSO_App_Dev_Project
{
    public class Mouse
    {
        private int id;
        private char groupId;
        private decimal height;
        private decimal length;
        private decimal width;
        private decimal weight;
        private decimal dose1Volume;
        private bool dose1Completed;
        private decimal dose2Volume;
        private bool dose2Completed;
        private string comments;

        public Mouse(int id, char groupId, decimal height, decimal length, decimal width, decimal weight, decimal dose1Volume, string dose1Completed, decimal dose2Volume, string dose2Completed, string comments)
        {
            Id = id;
            GroupId = groupId;
            Height = height;
            Length = length;
            Width = width;
            Weight = weight;
            Dose1Volume = dose1Volume;
            Dose2Volume = dose2Volume;
            Comments = comments;

            // dose1Completed & dose2Completed have string inputs because when grabbing from database
            switch (dose1Completed)
            {
                case "Yes":
                case "yes":
                    Dose1Completed = true;
                    break;
                case "No":
                case "no":
                    Dose1Completed = false;
                    break;
                default:
                    Dose1Completed = false;
                    break;
            }
            switch (dose2Completed)
            {
                case "Yes":
                case "yes":
                    Dose2Completed = true;
                    break;
                case "No":
                case "no":
                    Dose2Completed = false;
                    break;
                default:
                    Dose2Completed = false;
                    break;
            }
        }

        public Mouse(int id, char groupId, decimal height, decimal length, decimal width, decimal weight, decimal dose1Volume, bool dose1Completed, decimal dose2Volume, bool dose2Completed, string comments)
        {
            Id = id;
            GroupId = groupId;
            Height = height;
            Length = length;
            Width = width;
            Weight = weight;
            Dose1Volume = dose1Volume;
            Dose2Volume = dose2Volume;
            // dose1Completed & dose2Completed have boolean inputs here
            Dose1Completed = dose1Completed;
            Dose2Completed = dose2Completed;
            Comments = comments;
        }

        public int Id 
        {
            get 
            {
                return id;
            }
            set 
            { 
                this.id = value;
            }
        }
        public char GroupId
        {
            get
            {
                return groupId;
            }
            set
            {
                this.groupId = value;
            }
        }
        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
            }
        }
        public decimal Length
        {
            get
            {
                return length;
            }
            set
            {
                this.length = value;
            }
        }
        public decimal Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public decimal Dose1Volume
        {
            get
            {
                return dose1Volume;
            }
            set
            {
                this.dose1Volume = value;
            }
        }
        public bool Dose1Completed
        {
            get
            {
                return dose1Completed;
            }
            set
            {
                this.dose1Completed = value;
            }
        }
        public decimal Dose2Volume
        {
            get
            {
                return dose2Volume;
            }
            set
            {
                this.dose2Volume = value;
            }
        }
        public bool Dose2Completed
        {
            get
            {
                return dose2Completed;
            }
            set
            {
                this.dose2Completed = value;
            }
        }
        public string Comments
        {
            get
            {
                return comments;
            }
            set
            {
                this.comments = value;
            }
        }

    }
}
