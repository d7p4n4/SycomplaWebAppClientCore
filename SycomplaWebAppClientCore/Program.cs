using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace SycomplaWebAppClientCore
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyClass dummy = new DummyClass()
            {
                Dummy = "test"
            };

            string URL = "https://service.sycompla.hu/dummy";

            string DATA = JsonConvert.SerializeObject(dummy);

            DummyResult dummyResult = new DummyResult();
            try
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

                if (message.IsSuccessStatusCode)
                {
                }
                else
                {
                    Console.WriteLine("még dolgozz rajta");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
    
}
