﻿using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    
    public class ProductService : IProductService
    {
        private string uri = "http://localhost:8080";
        private readonly HttpClient client;

        public ProductService()
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

        public async Task<int> GetLastAddedProductID()
        {
            string message = await client.GetStringAsync(uri+"/products/1/1");
            return JsonSerializer.Deserialize<int>(message);
        }
    }
}
