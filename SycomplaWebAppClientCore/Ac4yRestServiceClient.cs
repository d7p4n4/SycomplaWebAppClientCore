using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SycomplaWebAppClientCore
{
    public class Ac4yRestServiceClient
    {
        public string GET(string URL, string DATA)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(URL);
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(URL),
                Content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json"),
            };

            HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");

            HttpResponseMessage message = httpClient.SendAsync(request).Result;
            string result = message.Content.ReadAsStringAsync().Result;

            return result;
        }
    }
}
