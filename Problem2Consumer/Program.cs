
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace Problem2Consumer
{
    class Program
    {
        private static readonly HttpClient Client = new HttpClient();

        private static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        private static async Task<IEnumerable<string>> GetItems(string path)
        {
            var response = await Client.GetAsync(path);

            if (!response.IsSuccessStatusCode) return null;

     //       return await response.Content.ReadAsAsync<List<string>>();
        }

        private static async Task RunAsync()
        {
            // Update your local service port no. / service APIs etc in the following line
            Client.BaseAddress = new Uri("http://localhost:57579/api/values/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                var items = await GetItems("http://localhost:57579/api/values/");
                Console.WriteLine("Items read using the web api GET");
                Console.WriteLine(string.Join(string.Empty, items.Aggregate((current, next) => current + ", " + next)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}