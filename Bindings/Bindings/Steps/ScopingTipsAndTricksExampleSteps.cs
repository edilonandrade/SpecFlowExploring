using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Bindings.Steps
{
    //Como está tagada com manual, esses teste são são executados
    [Binding, Scope(Tag ="manual")]
    public class ScopingTipsAndTricksExampleSteps
    {
        [Given(@""), When(@""), Then(@"")]
        public void Given()
        {
            Debug.Print(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [Given(@"""(.*)"""), When(@"""(.*)"""), Then(@"""(.*)""")]
        public void Given(string parametro)
        {
            Debug.Print(ScenarioContext.Current.ScenarioInfo.Title);
            Debug.Print(parametro);
        }
    }
}
