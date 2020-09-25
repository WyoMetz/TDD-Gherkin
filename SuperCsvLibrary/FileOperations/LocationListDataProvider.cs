using SuperCsvLibrary.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCsvLibrary.FileOperations
{
    internal class LocationListDataProvider : ILocationListDataProvider
    {
        private IFileReader Reader { get; set; }
        private IFileWriter Writer { get; set; }

        LocationListDataProvider(IFileReader reader, IFileWriter writer)
        {
            Reader = reader;
            Writer = writer;
        }

        //Some Fancy Concrete Not Implemented Exceptions
        public IList<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }

        public IList<Location> GetByBuildingNumber(int buildingNumber)
        {
            throw new NotImplementedException();
        }

        public Location GetByID(string ID)
        {
            throw new NotImplementedException();
        }

        public IList<Location> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<Location> GetByRoom(int room)
        {
            throw new NotImplementedException();
        }

        public IList<Location> GetByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public IList<Location> GetByTechnicalArea(int technicalArea)
        {
            throw new NotImplementedException();
        }
    }
}
