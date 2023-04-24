using System.Text;
using System.Collections.Concurrent;
using System.Net.Http.Json;


namespace Lesson23
{
    internal class Program
    {
        private static async Task Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            HttpClient httpClient = new HttpClient();
           var resp = await httpClient.GetAsync("https://www.fruityvice.com/api/fruit/all");
           resp.EnsureSuccessStatusCode();
           string content = await resp.Content.ReadAsStringAsync();
           ProductModel[] products = await resp.Content.ReadFromJsonAsync<ProductModel[]>();
        }
    }
}