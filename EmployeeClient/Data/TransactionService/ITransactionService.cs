using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    interface ITransactionService
    {
        Task UpdateToReady(int transactionid);
        Task UpdateToDelivered(int transactionid);
    }
}
