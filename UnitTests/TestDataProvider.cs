﻿using SuperCsvLibrary.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class TestDataProvider : ILocationListDataProvider
    {
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
