using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmployeeClient.Models
{
    public class WPJoin
    {
        [JsonPropertyName("warehouseProduct")]
        public WarehouseProduct warehouseProduct { get; set; }
        [JsonPropertyName("product")]

        public Product product { get; set; }
        
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }


    }
}
