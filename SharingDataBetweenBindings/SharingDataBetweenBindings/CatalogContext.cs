using SharingDataBetweenBindings.Model;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SharingDataBetweenBindings
{
    public class CatalogContext
    {
        public CatalogContext()
        {            
            ReferenceBooks = new ReferenceBookList();
        }

        public ReferenceBookList ReferenceBooks { get; set; }
    }

    [Binding]
    public class BookSteps
    {
        private readonly CatalogContext _catalogContext;

        public BookSteps(CatalogContext catalogContext)
        {
            _catalogContext = catalogContext;
        }

        [Given(@"the following books")]
        public void GivenTheFollowingBooks(Table table)
        {
            foreach(var book in table.CreateSet<Book>())
            {
                SaveBook(book);
                _catalogContext.ReferenceBooks.Add(book.Id, book);
            }
        }

        private void SaveBook(object book)
        {            
        }
    }




}
