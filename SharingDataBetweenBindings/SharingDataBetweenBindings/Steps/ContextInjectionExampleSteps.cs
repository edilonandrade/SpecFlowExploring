using BoDi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharingDataBetweenBindings.Model;
using System;
using TechTalk.SpecFlow;

namespace SharingDataBetweenBindings.Steps
{
    [Binding]
    public class MyStepDefs
    {
        private readonly PersonData personData;

        public MyStepDefs(PersonData personData)
        {
            this.personData = personData;
        }

        [Given(@"The person ""(.*)"" ""(.*)""")]
        public void GivenThePerson(string firstName, string lastName)
        {
            personData.FirstName = firstName; //write into the shared data
            personData.LastName = lastName;
            //...do other things you need
        }
    }

    [Binding]
    public class OtherStepsDefs
    {
        private readonly PersonData personData;

        public OtherStepsDefs(PersonData personData)
        {
            this.personData = personData;
        }

        [Then(@"The person data is properly displayed")]
        public void ThenThePersonDataIsProperlyDisplayed()
        {
            var displayedData = "FIRSTNAME LASTNAME";// get the displayed data from the app
                                    // read from shared data, to perform assertions
            Assert.AreEqual(personData.FirstName + " " + personData.LastName,
            displayedData, "Person name was not displayed properly");
        }

    }

    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer objectContainer;

        public WebDriverSupport (IObjectContainer objectContainer)
        {
            this.objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void InitializeWebDriver()
        {
            var webDrive = new FirefoxDriver();
            objectContainer.RegisterInstanceAs<IWebDriver>(webDrive);
        }
    }
}
