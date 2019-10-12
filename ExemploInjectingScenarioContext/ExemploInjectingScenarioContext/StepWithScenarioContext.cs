using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ExemploInjectingScenarioContext
{
    [Binding]
    public class StepWithScenarioContext : Steps
    {
        [Given(@"I put something into the context")]
        public void GivenIPutSomethingIntoTheContext()
        {
            this.ScenarioContext.Set("test-value-Step", "test-key-Steps");
        }

    }
}
