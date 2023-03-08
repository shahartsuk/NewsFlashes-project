using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace News.Entities
{
    public class RequestGet
    {
        public async Task XMLRequestGet()
        {
            using (var client = new HttpClient())
            {
                // Make a GET request to the URL 
                var response = await client.GetAsync("https://www.walla.co.il/rss ");

                // Ensure the response was successful 
                response.EnsureSuccessStatusCode();

                // Read the content of the response 
                var content = await response.Content.ReadAsStringAsync();

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(content);

                foreach(XmlNode node in xmlDoc.SelectNodes("//item")) 
                {
                    //string title = node.SelectNodes("title")[0].InnerText;
                    string title = node["title"].InnerText;
                    string link = node["link"].InnerText;
                    string description = node["description"].InnerText;
                    string url = node["url"].InnerText;
                }

                // Output the content of the response 
                Console.WriteLine(content);
            }
        }
    }
}
