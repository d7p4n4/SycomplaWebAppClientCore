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
                string response = new Ac4yRestServiceClient().GET("https://service.sycompla.hu/dummy", "{'Dummy': 'Test'}");
                Console.WriteLine(response);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }


    }
    
}
