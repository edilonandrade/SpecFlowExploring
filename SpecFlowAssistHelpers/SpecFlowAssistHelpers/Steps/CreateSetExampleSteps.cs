using SpecFlowAssistHelpers.Models;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowAssistHelpers.Steps
{
    [Binding]
    public class CreateSetExampleSteps
    {
        [Given(@"these products exist")]
        public void GivenTheseProductsExist(Table produtos)
        {
            var _products = produtos.CreateSet<Product>();

            foreach (var product in _products)
                foreach(var prop in product.GetType().GetProperties())
                    Debug.Print($"{prop.Name} - {prop.GetValue(product, null)}");
        }
    }
}
