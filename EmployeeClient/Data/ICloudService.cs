using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public interface ICloudService
    {
        Task AddProductAsync(Product product);
    }
}
