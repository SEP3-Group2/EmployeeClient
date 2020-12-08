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
        Task OrderProductFromManufacturerAsync(OrderProduct orderProduct);
        Task OrderProductFromStore(OrderProduct orderProduct);
        Task DecrementOrderQuantity(OrderProduct orderProduct);
        Task<List<WarehouseProduct>> GetWarehouseProductFromStoresById(WarehouseProduct warehouseProduct);

        Task UpdateWarehouseQuantity(int storeid, int productid, int quantity);

    }
}
