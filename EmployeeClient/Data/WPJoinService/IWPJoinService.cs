using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    interface IWPJoinService
    {
        Task<List<WPJoin>> GetAllWPJoinAsync();
        Task<List<WPJoin>> GetStoreWPJoinAsync(int storeid);
    }
}
