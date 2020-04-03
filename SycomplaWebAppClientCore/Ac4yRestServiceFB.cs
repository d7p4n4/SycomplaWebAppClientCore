using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace SycomplaWebAppClientCore
{
    class Ac4yRestServiceFB
    {
        public string SendNotification()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://fcm.googleapis.com/fcm/send"))
                {
                    request.Headers.TryAddWithoutValidation("Authorization", "key=AAAAHIfHKTw:APA91bF77GYg_jDtMKHHJE0XFA6Tk-O5x5BYdMDxZ6SebzD7Bz5czj8G4aFkqs3bFm66Lyit-QO08q1FL8x1Q75qmBOfBj4XhkWRgdiKdTlY39nBJ2r60IDi7b08R1Mk9R-0oR7dBos3");

                    request.Content = new StringContent("{\n \"to\" : \"doYof6dP9g8:APA91bFxnta7tbQIpK62SaN6FpfNsW2SqdqpKX-X8Xiv5X1MNd9eVgnbQ3LGl8L89HH6BUAR_B6dpM7nBU1F7dGs11PNWeTGtyrSmtr-eUlE9MXQ1EPSbf1jepYAx-lb3nUi-O7tObiR\",\n \"notification\" : {\n \"body\" : \"great match!\",\n \"title\" : \"Portugal vs. Denmark\",\n \"content_available\" : true,\n \"priority\" : \"high\"\n },\n \"data\" : {\n \"body\" : \"great match!\",\n \"title\" : \"Portugal vs. Denmark\",\n \"content_available\" : true,\n \"priority\" : \"high\"\n } \n}");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    var response = httpClient.SendAsync(request).Result;
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public string POSTFireBase(string URL, string DATA)
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
