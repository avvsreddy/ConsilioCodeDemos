using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace ProductsCatalogAPI.ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fetch all products from api and display


            // Step 1: discover the api address/uri
            string baseUri = "https://localhost:44307";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            client.BaseAddress = new Uri(baseUri);

            //var response = client.GetStringAsync($"{baseUri}/api/products?&$top=1").Result;
            var response = client.GetFromJsonAsync<List<Product>>($"{baseUri}/api/products?&$top=1").Result;

            Console.WriteLine(response[0].name);
            Console.WriteLine(response[0].price);

        }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Product
    {
        public int productId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string category { get; set; }
        public bool isAvailable { get; set; }
        public string brand { get; set; }
        public string country { get; set; }
    }


}
