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
    public class WarehouseProductService : IWarehouseProductService
    {
        private string uri = "http://localhost:8080";
        private readonly HttpClient client;

        public WarehouseProductService()
        {
            this.client = new HttpClient();
        }
        public async Task<List<WarehouseProduct>> GetWarehouseProductsAsync()
        {
            string message = await client.GetStringAsync(uri + "/warehouseproducts");
            List<WarehouseProduct> returnList = JsonSerializer.Deserialize<List<WarehouseProduct>>(message);

            return returnList;
        }
        public async Task<List<WarehouseProduct>> GetStoreWarehouseProductsAsync(int storeid)
        {
            string message = await client.GetStringAsync(uri + "/warehouseproducts/"+storeid);
            List<WarehouseProduct> returnList = JsonSerializer.Deserialize<List<WarehouseProduct>>(message);
            Console.WriteLine(returnList);
            Console.WriteLine("fhsdkhfklsj");

            return returnList;
        }

        public async Task AddWarehouseProductAsync(WarehouseProduct warehouseProduct)
        {
            string warehouseProductAsJson = JsonSerializer.Serialize(warehouseProduct);
            HttpContent content = new StringContent(warehouseProductAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/warehouseproducts", content);
        }
    }
}
