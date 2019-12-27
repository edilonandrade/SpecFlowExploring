using SpecFlowAssistHelpers.Models;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowAssistHelpers.Steps
{
    [Binding]
    public class CompareToInstanceExampleSteps
    {
        [Then(@"the person should have the following values")]
        public void ThenThePersonShouldHaveTheFollowingValues(Table person)
        {
            // you don't have to get person this way, this is just for demo
            var _person = new Person
            {
                FirstName = "John",
                LastName = "Galt",
                YearsOld = 54
            };

            person.CompareToInstance<Person>(_person);
        }
    }
}
