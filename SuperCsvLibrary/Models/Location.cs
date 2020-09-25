using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCsvLibrary.Models
{
    public class Location
    {
        public string ID { get; set; }
        public int TechnicalArea { get; set; }
        public int BuildingNumber { get; set; }
        public string Name { get; set; }
        public string Room { get; set; }
        public string Status { get; set; }

        public string IsActive()
        {
            if(TechnicalArea > 5 || BuildingNumber <= 1300 || (Room.ToUpper() != "NULL" && Room.ToUpper() != ""))
            {
                return "NOT ACTIVE";
            }
            else
            {
                return "ACTIVE";
            }
        }
    }
}
