using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmployeeClient.Models
{
    public class WarehouseProduct
    {
        [JsonPropertyName("storeId")]
        public int storeId { get; set; }
        [JsonPropertyName("productId")]
        public int productId { get; set; }
        [JsonPropertyName("quantity")]
        public int quantity { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
