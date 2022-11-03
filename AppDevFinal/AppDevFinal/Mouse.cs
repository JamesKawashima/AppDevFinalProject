using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevFinal
{
    internal class Mouse
    {
        private static int idNum = 0;
        private int id;
        private int height;
        private int width;
        private int weight;
        private int experimentId;
        private string experimentName;
        private string doseName;
        private int doseML;

        public Mouse(int height, int width, int weight, int experimentId, 
            string experimentName, string doseName, int doseML)
        {

            this.id = id++;
            this.height = height;
            this.width = width;
            this.weight = weight;
            this.experimentId = experimentId;
            this.experimentName = experimentName;
            this.doseName = doseName;
            this.doseML = doseML;
        }

        public Mouse(int height, int width, int weight)
        {
            this.id = id++;
            this.height = height;
            this.height = height;
            this.width = width;
            this.weight = weight;
        }
    }
}
