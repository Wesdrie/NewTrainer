using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrainer
{
    /// <summary>
    /// OBJECT STRUCTURE FOR EXPECTED DATA.
    /// </summary>
    internal class CallAreas
    {
        public string AreaNumber { get; set; }
        public string AreaName { get; set; }
        public string AreaDescription { get; set; }

        public CallAreas(string areaNumber, string areaName, string areaDescription)
        {
            this.AreaNumber = areaNumber;
            this.AreaName = areaName;
            this.AreaDescription = areaDescription;
        }

        public CallAreas(string areaNumber, string areaName)
        {
            this.AreaNumber = areaNumber;
            this.AreaName = areaName;
        }
    }
}

