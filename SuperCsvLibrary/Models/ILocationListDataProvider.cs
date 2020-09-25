using System;
using System.Collections.Generic;
using System.Text;

namespace SuperCsvLibrary.Models
{
    public interface ILocationListDataProvider
    {
        IList<Location> GetAllLocations();
        IList<Location> GetByTechnicalArea(int technicalArea);
        IList<Location> GetByBuildingNumber(int buildingNumber);
        IList<Location> GetByName(string name);
        IList<Location> GetByRoom(int room);
        IList<Location> GetByStatus(string status);
        Location GetByID(string ID);
    }
}
