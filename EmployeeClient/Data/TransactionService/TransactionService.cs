using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public class TransactionService : ITransactionService
    {
        HttpClient client;
        private string uri = "http://localhost:8080/transaction";

        public TransactionService()
        {
            client = new HttpClient();
        }

        public async Task UpdateToDelivered(int transactionid)
        {
            await client.GetStringAsync(uri + "/delivered/" + transactionid);
        }

        public async Task UpdateToReady(int transactionid)
        {
            await client.GetStringAsync(uri + "/ready/" + transactionid);
        }
    }
}
