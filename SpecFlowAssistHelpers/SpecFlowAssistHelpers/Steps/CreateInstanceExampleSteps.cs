using SpecFlowAssistHelpers.Models;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace SpecFlowAssistHelpers.Steps
{
    [Binding]
    public class CreateInstanceExampleSteps
    {
        [Given(@"I entered the following data into the new account form in vertical:")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountFormInVertical(Table account)
        {
            var _account = account.CreateInstance<Account>();
            foreach (var prop in _account.GetType().GetProperties())
                Debug.Print($"{prop.Name} - {prop.GetValue(_account, null)}");
        }
    }
}
