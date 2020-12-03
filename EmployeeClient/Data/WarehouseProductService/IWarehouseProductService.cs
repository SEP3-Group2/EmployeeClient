using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public interface IWarehouseProductService
    {
        Task<List<WarehouseProduct>> GetWarehouseProductsAsync();
        Task<List<WarehouseProduct>> GetStoreWarehouseProductsAsync(int storeid);
        Task AddWarehouseProductAsync(WarehouseProduct warehouseProduct);

    }
}
