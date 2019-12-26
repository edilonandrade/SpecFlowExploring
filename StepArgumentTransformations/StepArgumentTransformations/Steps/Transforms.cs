using System;
using TechTalk.SpecFlow;
using System.Xml;
using System.Collections.Generic;
using TechTalk.SpecFlow.Assist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StepArgumentTransformations.Steps
{
    [Binding]
    public class Transforms
    {
        [StepArgumentTransformation(@"in (\d+) days")]
        public DateTime InDaysTransform(int days)
        {
            return DateTime.Today.AddDays(days);
        }

        [StepArgumentTransformation]
        public XmlDocument XmlTransform(string xml)
        {
            XmlDocument result = new XmlDocument();
            result.LoadXml(xml);
            return result;
        }

        [StepArgumentTransformation]
        public IEnumerable<Book> BooksTransform(Table booksTable)
        {
            return (IEnumerable<Book>)booksTable.CreateSet<Book>();
        }

        [Given(@"Show messenger""(.*)""")]
        public void GiveShowMessenger()
        {
            string chave = Nfe.Tab();
            Assert.IsNotNull(chave);
        }
    }

    public class Book
    {

    }

    public static class Nfe
    {
        public static string Tab()
        {
            return null;
        }
    }
}
