using System;
using TechTalk.SpecFlow;

namespace Bindings.Steps
{
    [Binding]
    public class DifferentStepsforDifferentTagsSteps
    {
        [When(@"I perform a simple search on"), Scope(Tag ="controller")]
        public void WhenIPerformASimpleSearchOn()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I perform a simple search on"), Scope(Tag = "web")]
        public void WebIPerformASimpleSearchOn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
