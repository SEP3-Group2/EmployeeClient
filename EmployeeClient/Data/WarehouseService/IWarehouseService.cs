using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    interface IWarehouseService
    {
        Task UpdateWarehouseQuantity(int storeid, int productid, int quantity);
    }
}
