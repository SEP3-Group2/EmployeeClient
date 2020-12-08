using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeClient.Models;

namespace EmployeeClient.Data
{
    public interface ITransactionProductService
    {
        Task<List<ReserveHistory>> getAllReserveHistory();
        Task<List<ReserveHistory>> getReserveHistoryByStoreEmail(int storeid, string email);
        Task<List<ReserveHistory>> getReserveHistoryByStoreEmailDelivery(int storeid, string email, string delivery);
    }
}
