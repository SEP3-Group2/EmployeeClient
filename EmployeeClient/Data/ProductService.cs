using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public class ProductService 
    {
        private string productFile = "product.json";
        public IList<Product> products { get; private set; }
        public ProductService()
        {
            products = File.Exists(productFile) ? ReadData<Product>(productFile) : new List<Product>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        private void WriteTodosToFile()
        {
            string productsAsJson = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
            using (StreamWriter outputFile = new StreamWriter(productFile, false))
            {
                outputFile.Write(productsAsJson);
            }
        }

        public async Task AddProductAsync(Product product)
        {
            int max = products.Max(product => product.Id);
            product.Id = (++max);
            products.Add(product);
            WriteTodosToFile();
        }
    }
}
