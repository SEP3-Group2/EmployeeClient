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

        public async Task OrderProductFromManufacturerAsync(OrderProduct orderProduct)
        {
            string orderProductAsJson = JsonSerializer.Serialize(orderProduct);
            HttpContent content = new StringContent(orderProductAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/warehouseproducts/orderProductFromManufacturer", content);
        }

        public async Task OrderProductFromStore(OrderProduct orderProduct)
        {
            string orderProductAsJson = JsonSerializer.Serialize(orderProduct);
            HttpContent content = new StringContent(orderProductAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/warehouseproducts/orderProductFromStore", content);
        }

        public async Task DecrementOrderQuantity(OrderProduct orderProduct)
        {
            string orderProductAsJson = JsonSerializer.Serialize(orderProduct);
            HttpContent content = new StringContent(orderProductAsJson,
                Encoding.UTF8,
                "application/json");
            await client.PostAsync(uri + "/warehouseproducts/decrementProductQuantity", content);
        }

        public async Task<List<WarehouseProduct>> GetWarehouseProductFromStoresById(WarehouseProduct warehouseProduct)
        {
            string message = await client.GetStringAsync(uri + "/warehouseproducts/" +warehouseProduct.storeId+"/"+warehouseProduct.productId+"/"+warehouseProduct.quantity);
            List<WarehouseProduct> returnList = JsonSerializer.Deserialize<List<WarehouseProduct>>(message);

            return returnList;
        }

        public async Task UpdateWarehouseQuantity(int storeid, int productid, int quantity)
        {
            await client.GetStringAsync(uri + "/warehouseproducts/update/" + storeid + "/" + productid + "/" + quantity);
        }
    }
}
