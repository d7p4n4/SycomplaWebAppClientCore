using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public string GETWithParameter(string URL)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(URL);
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage message = httpClient.GetAsync(URL).Result;
            string result = message.Content.ReadAsStringAsync().Result;

            return result;
        }

        public string POST(string URL, string DATA)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://service.sycompla.hu/dummy"))
                {
                    request.Content = new StringContent(DATA);
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = httpClient.SendAsync(request).Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
            }/*
            {
                    var response = httpClient.PostAsync(URL, request.Content).Result;
                    string result = response.Content.ReadAsStringAsync().Result;
                    return result;
                }
            }*/
        }
    }
}
