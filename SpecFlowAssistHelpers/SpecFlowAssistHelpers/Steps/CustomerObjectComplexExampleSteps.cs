using SpecFlowAssistHelpers.Extensions;
using SpecFlowAssistHelpers.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowAssistHelpers.Steps
{
    [Binding]
    public class CustomerObjectComplexExampleSteps
    {
        [Given(@"I have the following customers")]
        public void GivenIHaveTheFollowingCustomers(Table customer)
        {
            var _customer = customer.VerifyPropertiesAndCreateSet<Customer>();
        }
    }
}
