using Gherkin.Ast;

using NuGet.Frameworks;

using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TechTalk.SpecFlow;

namespace GherkinTests.Steps
{
    [Binding]
    public class StatusSearchStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private SuperCsvLibrary.Models.Location Location;

        public StatusSearchStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Location = new SuperCsvLibrary.Models.Location();
        }

        [Given(@"The Technical Area is ([0-9]*[A-Z]*)")]
        public void GivenTheBuildingNumberExists(int taNumber)
        {
            Location.TechnicalArea = taNumber;
        }

        [Given(@"BLDG_NUM is ([0-9]*[A-Z]*)")]
        public void WhenBLDG_NUMIs(int buildingNumber)
        {
            Location.BuildingNumber = buildingNumber;
        }

        [Given(@"Room Number is ([0-9]*[A-Z]*[0-9]*)")]
        public void WhenRoomNumberIs(string roomString)
        {
            Location.Room = roomString;
        }

        [Then(@"the Status is ([A-Z]*\s*[A-Z]*)")]
        public void ThenTheStatusShouldBeNOTACTIVE(string status)
        {
            Assert.IsTrue(Location.IsActive() == status);
        }
    }
}

