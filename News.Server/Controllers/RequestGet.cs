using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace News.Server.Controllers
{
    public class RequestGet
    {
        static async Task Main(string[] args)

        {
            using (var client = new HttpClient())
            {
                // Make a GET request to the URL 
                var response = await client.GetAsync("https://www.example.com");

                // Ensure the response was successful 
                response.EnsureSuccessStatusCode();

                // Read the content of the response 
                var content = await response.Content.ReadAsStringAsync();

                // Output the content of the response 
                Console.WriteLine(content);
            }
        }
    }
}
