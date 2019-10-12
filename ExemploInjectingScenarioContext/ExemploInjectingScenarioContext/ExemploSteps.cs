using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace ExemploInjectingScenarioContext
{
    [Binding]
    public class ExemploSteps
    {
        private readonly ScenarioContext scenarioContext;

        public ExemploSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            scenarioContext.Set("test-value", "test-key");
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Debug.Print($"Valor da chave: {scenarioContext.Get<string>("test-key")}\n");
            Debug.Print($"Valor da chave no cenario 2 steps: {scenarioContext.Get<string>("test-key-Steps")}\n");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Debug.Print("Não implementado");
        }
    }
}
