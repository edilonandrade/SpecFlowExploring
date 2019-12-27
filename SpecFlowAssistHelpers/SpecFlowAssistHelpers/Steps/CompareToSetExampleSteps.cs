using SpecFlowAssistHelpers.Models;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowAssistHelpers.Steps
{
    [Binding]
    public class CompareToSetExampleSteps
    {
        [Then(@"I get back the following accounts")]
        public void ThenIGetBackTheFollowingAccounts(Table table)
        {
            List<Account> accounts = new List<Account>
            {
                new Account
                {
                    Id = "1",
                    FirstName = "John",
                    LastName = "Galt"
                },

                new Account
                {
                    Id = "2",
                    FirstName = "Howard",
                    LastName = "Roark"
                }
            };

            table.CompareToSet<Account>(accounts);
        }
    }
}
