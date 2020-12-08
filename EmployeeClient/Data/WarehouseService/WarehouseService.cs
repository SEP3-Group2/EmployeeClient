using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public class WarehouseService : IWarehouseService
    {
        HttpClient client;
        private string uri = "http://localhost:8080/warehouseproducts";

        public WarehouseService()
        {
            client = new HttpClient();
        }

        public async Task UpdateWarehouseQuantity(int storeid, int productid, int quantity)
        {
            await client.GetStringAsync(uri + "/update/" + storeid + "/" + productid + "/" + quantity);
        }
    }
}
