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
                string response = new Ac4yRestServiceClient().POST("https://service.sycompla.hu/dummy", "{\n\t\"dummy\": \"PostTest\"\n}");
                Console.WriteLine(response);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }


    }
    
}
