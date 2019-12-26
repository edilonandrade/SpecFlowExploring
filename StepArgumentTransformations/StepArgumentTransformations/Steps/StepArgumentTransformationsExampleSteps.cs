using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace StepArgumentTransformations.Steps
{
    [Binding]
    public class StepArgumentTransformationsExampleSteps
    {
        [Given(@"in '(.*)' days")]
        public void GivenInDays(int p0)
        {
            Debug.Print(ScenarioContext.Current.ScenarioInfo.Title);
        }
    }
}
