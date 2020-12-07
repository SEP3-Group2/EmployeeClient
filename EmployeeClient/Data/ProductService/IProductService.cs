using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public interface IProductService
    {
        Task AddProductAsync(Product product);
        Task<int> GetLastAddedProductID();
        Task<List<Product>> GetAllProductsAsync();
        Task<IList<Product>> GetTitleCategoryPriceFilteredProductsAsync(string title, string category, string price);
        Task<Product> GetProductByIdAsync(int id);
        Task ModifyProductAsync(Product product);
        void setProductId(int id);
        int getProductId();
    }
}

