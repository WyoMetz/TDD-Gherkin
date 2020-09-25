using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCsvLibrary.Models
{
    public class LocationsList
    {
        public IList<Location> Locations { get; set; }

        private ILocationListDataProvider Provider { get; set; }


        public LocationsList(ILocationListDataProvider provider)
        {
            Provider = provider;
        }


        //Methods Here
    }
}
