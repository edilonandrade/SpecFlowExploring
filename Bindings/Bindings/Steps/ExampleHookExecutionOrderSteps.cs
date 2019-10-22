using System.Diagnostics;
using TechTalk.SpecFlow;

namespace Bindings.Steps
{
    [Binding]
    public class ExampleHookExecutionOrderSteps
    {
        [BeforeScenario(Order = 100)]
        public void LoginUser()
        {
            Debug.Print("...so we can log in to a clean \n");
        }

        [BeforeScenario(Order = 0)]
        public void CleanDatabase()
        {
            Debug.Print("we need to run this first\n");
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            Debug.Print("Não implementado, somente para teste do BeforeScenario Order\n");
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Debug.Print("Não implementado, somente para teste do BeforeScenario Order\n");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Debug.Print("Não implementado, somente para teste do BeforeScenario Order\n");
        }

    }
}
