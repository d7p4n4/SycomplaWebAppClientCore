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

            DummyResult dummyResult = new DummyResult();
            try
            {
                //string response = new Ac4yRestServiceClient().GET("https://service.sycompla.hu/dummy", "{'Dummy': 'Test'}");
                //string response = new Ac4yRestServiceClient().GETWithParameter("https://service.sycompla.hu/dummy/GetParameter?dummy=ParameterTest");
                //string response = new Ac4yRestServiceClient().POST("https://service.sycompla.hu/dummy", "{\n\t\"dummy\": \"PostTest\"\n}");

                //string response = new Ac4yRestServiceFB().POSTFireBase("https://service.sycompla.hu/firebase/FireBaseNotificationSend", "{\"FireBaseKey\":\"AAAAHIfHKTw:APA91bF77GYg_jDtMKHHJE0XFA6Tk-O5x5BYdMDxZ6SebzD7Bz5czj8G4aFkqs3bFm66Lyit-QO08q1FL8x1Q75qmBOfBj4XhkWRgdiKdTlY39nBJ2r60IDi7b08R1Mk9R-0oR7dBos3\",\"Token\":\"doYof6dP9g8:APA91bFxnta7tbQIpK62SaN6FpfNsW2SqdqpKX-X8Xiv5X1MNd9eVgnbQ3LGl8L89HH6BUAR_B6dpM7nBU1F7dGs11PNWeTGtyrSmtr-eUlE9MXQ1EPSbf1jepYAx-lb3nUi-O7tObiR\",\"MessageBody\":\"Új FB teszt üzenet!\",\"MessageTitle\":\"Műkodj!\"}");

                string response = new Ac4yRestServiceClient("https://localhost:44339").POST("/gigserver/loginrequest", "{\n\t\"fbToken\": \"c6QuWuYRrEDsn58FUUp_7D:APA91bEDmyi_yR7tIBEqrfg2hRHAOf1j2Nre0QAdT4Btx3bJrxropZYTmD6YooKh5O59WQZF_9EHAM04if5BJuZwk_16-FYmj7rs31zIuoI_ZIrzXA3TwPmpcxZRVNZ4dnVDaqn3Z7ZD\"\n}");


                Console.WriteLine(response);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }


    }
    
}
