using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SycomplaWebAppClientCore
{
    class GigRestService
    {
        public string LoginRequest(string URL, string DATA)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), URL))
                {
                    request.Content = new StringContent(DATA);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = httpClient.SendAsync(request).Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
