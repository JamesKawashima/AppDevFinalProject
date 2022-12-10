using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevFinal
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

        public Mouse(int id, char groupId, decimal height, decimal length, decimal width, decimal weight, decimal dose1Volume, string dose1Completed, decimal dose2Volume, string dose2Completed, string comments) {
            this.id = id;
            this.groupId = groupId;
            this.height = height;
            this.length = length;
            this.width = width;
            this.weight = weight;
            this.dose1Volume = dose1Volume;
            this.dose2Volume = dose2Volume;
            this.comments = comments;

            // dose1Completed & dose2Completed have string inputs because when grabbing from database
            switch (dose1Completed) {
                case "Yes":
                case "yes":
                    this.dose1Completed = true;
                    break;
                case "No":
                case "no":
                    this.dose1Completed = false;
                    break;
                default:
                    this.dose1Completed = false;
                    break;
            }
            switch (dose2Completed)
            {
                case "Yes":
                case "yes":
                    this.dose2Completed = true;
                    break;
                case "No":
                case "no":
                    this.dose2Completed = false;
                    break;
                default:
                    this.dose2Completed = false;
                    break;
            }
        }

        public Mouse(int id, char groupId, decimal height, decimal length, decimal width, decimal weight, decimal dose1Volume, bool dose1Completed, decimal dose2Volume, bool dose2Completed, string comments)
        {
            this.id = id;
            this.groupId = groupId;
            this.height = height;
            this.length = length;
            this.width = width;
            this.weight = weight;
            this.dose1Volume = dose1Volume;
            this.dose2Volume = dose2Volume;
            // dose1Completed & dose2Completed have boolean inputs here
            this.dose1Completed = dose1Completed;
            this.dose2Completed = dose2Completed;
            this.comments = comments;
        }

    }
}
