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

        [Given(@"I entered the following data into the new account form in horizontal:")]
        public void GivenIEnteredTheFollowingDataIntoTheNewAccountFormInHorizontal(Table account)
        {
            var _account = account.CreateInstance<Account>();
            foreach (var prop in _account.GetType().GetProperties())
                Debug.Print($"{prop.Name} - {prop.GetValue(_account, null)}");

            Debug.Print("Exemplo para o segundo tipo de mapeamento.");

            var _accountDois = account.CreateInstance<(string name, DateTime birthDate,
                int heightInInches, decimal bankAccountBalance)>();

            Debug.Print($"Name: {_accountDois.name}");
            Debug.Print($"BirthDate: {_accountDois.birthDate}");
            Debug.Print($"HeightInInches: {_accountDois.heightInInches}");
            Debug.Print($"BankAccountBalance: {_accountDois.bankAccountBalance}");
        }

    }
}
