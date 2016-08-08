using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace TplSample
{
    class Program
    {

        static void MakeHttpCall(int id)
        {
            using (var client = new HttpClient())
            {
                // Get the response.
                var response = client.GetAsync($"http://efa-aurir-samplewebservice.azurewebsites.net/api/values/get/{id}").Result;
            }
        }

        static void PerformACount(int multiplier)
        {
            for (var i = 0; i < 1000 * multiplier; i++)
            {

            }
        }

        //Use TPL(Task Parallel Library) to run a lot of expensive processes at once instead
        // of one at a time.
        static void Main(string[] args)
        {
            var ids = Enumerable.Range(0, 1000);

            Console.WriteLine($"Starting single thread at {DateTime.Now.ToLongTimeString()}");
            foreach (var id in ids) MakeHttpCall(id);
            Console.WriteLine($"Ending single thread at {DateTime.Now.ToLongTimeString()}\n\n");

            Console.WriteLine($"Starting parallel thread at {DateTime.Now.ToLongTimeString()}");
            Parallel.ForEach(ids, id => MakeHttpCall(id));

            Console.WriteLine($"Ending parallel thread at {DateTime.Now.ToLongTimeString()}\n\n");

            Console.ReadLine();
        }
    }
}