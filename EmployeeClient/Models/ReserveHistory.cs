using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmployeeClient.Models
{
    public class ReserveHistory
    {
        [JsonPropertyName("transactionod")]
        public int Transactionod { get; set; }
        [JsonPropertyName("storeid")]
        public int Storeid { get; set; }
        [JsonPropertyName("productid")]
        public int ProductId { get; set; }
        [JsonPropertyName("customername")]
        public string Customername { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("deliverymethod")]
        public string Deliverymethod { get; set; }
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("totalprice")]
        public double Totalprice { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
