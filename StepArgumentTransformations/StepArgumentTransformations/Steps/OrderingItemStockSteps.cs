using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace StepArgumentTransformations.Steps
{
    [Binding]
    public class OrderingItemStockSteps
    {
        [Given(@"we have '(.*)' items in stock\.")]
        public void GivenWeHaveItemsInStock(string p0)
        {
            Debug.Print(ScenarioContext.Current.ScenarioInfo.Title);
            Debug.Print($"Parâmetro {p0}");
        }
        
        [When(@"we order '(.*)' item")]
        public void WhenWeOrderItem(int p0)
        {
            Debug.Print(ScenarioContext.Current.ScenarioInfo.Title);
        }
        
        [Then(@"we should have '(.*)' items in stock left\.")]
        public void ThenWeShouldHaveItemsInStockLeft_(int p0)
        {
            Debug.Print(ScenarioContext.Current.ScenarioInfo.Title);
        }
    }
}
