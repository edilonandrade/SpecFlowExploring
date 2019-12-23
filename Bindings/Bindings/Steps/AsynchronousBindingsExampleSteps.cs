using Bindings.WebRequest.Specs.Drivers;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Bindings.Steps
{
    [Binding]
    public class AsynchronousBindingsExampleSteps
    {
        WebDriver _webDriver = new WebDriver();

        [When(@"I want to get the web page ""(.*)""")]
        public async Task WhenIWantToGetTheWebPage(string url)
        {
            _webDriver.InitializeHttpClient();
            await _webDriver.HttpClientGet(url);
        }
    }
}
