using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bindings.WebRequest.Specs.Drivers
{
    public class WebDriver
    {
        private HttpClient _httpClient;
        private HttpResponseMessage _httpResponseMessage;

        public void InitializeHttpClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task HttpClientGet(string url)
        {
            _httpResponseMessage = await _httpClient.GetAsync(url);
        }
    }
}
