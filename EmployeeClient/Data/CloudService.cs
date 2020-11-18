using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    
    public class CloudService : ICloudService
    {
        private string uri = "http://localhost:8080";
        private readonly HttpClient client;

        public CloudService()
        {
            client = new HttpClient();
        }
        public async Task AddProductAsync(Product product)
        {
            string productAsJson = JsonSerializer.Serialize(product);
            HttpContent content = new StringContent(productAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/products", content);
        }
       
        public async Task<List<Product>> GetAllProductsAsync()
        {
            string message = await client.GetStringAsync(uri + "/products");
            List<Product> returnList = JsonSerializer.Deserialize<List<Product>>(message);

            return returnList;
        }
    }
}
