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

        [Given(@"The building number (.*) exists")]
        public void GivenTheBuildingNumberExists(int p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"TA is (.*)")]
        public void WhenTAIs(int p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"BLDG_NUM is (.*)")]
        public void WhenBLDG_NUMIs(int p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"Room Number is “(.*)”")]
        public void WhenRoomNumberIs(int p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"the Status should be “NOT ACTIVE”")]
        public void ThenTheStatusShouldBeNOTACTIVE()
        {
            _scenarioContext.Pending();
        }
    }
}

