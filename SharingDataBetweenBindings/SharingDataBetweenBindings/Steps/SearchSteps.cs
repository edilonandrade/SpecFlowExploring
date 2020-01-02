using SharingDataBetweenBindings.AspNetFaker;
using SharingDataBetweenBindings.Model;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SharingDataBetweenBindings.Steps
{
    [Binding]
    public class SearchSteps
    {
        //A classe real faz referência ao uso da ActionResult do Aps.Net
        //Esse exemplo está guardando o valor numa variável de resultado

        private ActionResult actionResult;
        
        [When(@"I perform a simple search on '(.*)'")]
        public void WhenIPerformASimpleSearchOn(string searchTerm)
        {
            var controller = new CatalogController();
                
            actionResult = controller.SearchItem(searchTerm);

        }
        
        [Then(@"the book list should exactly contain book '(.*)'")]
        public void ThenTheBookListShouldExactlyContainBook(string title)
        {
            var books = actionResult.Model<List<Book>>();
            CustomAssert.Any(books, b => b.Title == title);
        }
    }
}
