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

        public StatusSearchStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"The building number ([0-9]*[A-Z]*) exists")]
        public void GivenTheBuildingNumberExists(int buildingNumber)
        {
            Console.WriteLine($"Exists Building Number {buildingNumber}");
        }

        [When(@"TA is ([0-9]*[A-Z]*)")]
        public void WhenTAIs(int taNumber)
        {
            Console.WriteLine($"When TA is {taNumber}");
        }

        [When(@"BLDG_NUM is ([0-9]*[A-Z]*)")]
        public void WhenBLDG_NUMIs(int buildingNumber)
        {
            Console.WriteLine($"When BLDG is {buildingNumber}");
        }

        [When(@"Room Number is ([0-9]*[A-Z]*[0-9]*)")]
        public void WhenRoomNumberIs(string roomString)
        {
            Console.WriteLine($"When Room is {roomString}");
        }

        [Then(@"the Status should be ([A-Z]*\s*[A-Z]*)")]
        public void ThenTheStatusShouldBeNOTACTIVE(string status)
        {
            Console.WriteLine($"Status Is {status}");
            _scenarioContext.Pending();
        }
    }
}

