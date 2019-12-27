using SpecFlowAssistHelpers.Models;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowAssistHelpers.Steps
{
    [Binding]
    public class ColumnNamingExampleSteps
    {
        [Given(@"I entered the following data into the new account to column:")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountToColumn(Table table)
        {
            var _account = table.CreateInstance<Account>();
            foreach (var prop in _account.GetType().GetProperties())
                Debug.Print($"{prop.Name} - {prop.GetValue(_account, null)}");
        }
    }
}
