using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace News.Entities
{
    public class RequestPost
    {
        public async Task XMLRequestPost()
        {
            using (var client = new HttpClient())
            {
                // Create a JSON payload to be sent with the request 
                var payload = new { username = "example_username", password = "example_password" };

                // Make a POST request to the URL 
                var response = await client.PostAsJsonAsync("https://www.example.com/api/login", payload);

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
