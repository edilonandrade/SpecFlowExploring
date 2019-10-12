using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace ExemploInjectingScenarioContext
{
    [Binding]
    public class Exemplo2AcessoContextoCenarioSteps
    {
        private readonly ScenarioContext scenarioContext;

        public Exemplo2AcessoContextoCenarioSteps(ScenarioContext scenarioContext)
        {
            if (scenarioContext == null) throw new ArgumentNullException("scenarioContext");
            this.scenarioContext = scenarioContext;
        }

        [Given(@"I have (.*) into the calculator")]
        public void GivenIHaveIntoTheCalculator(int p0)
        {
            //A linha abaixo dá erro pois a aplicação não encontra a chave
            // Debug.Print($"Valor da chave no cenario 2: {scenarioContext.Get<string>("test-key")}\n");
            
            //Debug.Print($"Valor da chave no cenario 2 steps: {scenarioContext.Get<string>("test-key-Steps")}\n");
        }
        
        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result (.*) on the screen")]
        public void ThenTheResultOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
