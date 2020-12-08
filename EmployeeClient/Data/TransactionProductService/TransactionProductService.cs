using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using EmployeeClient.Models;

namespace EmployeeClient.Data
{
    public class TransactionProductService : ITransactionProductService
    {
        HttpClient client;
        private string uri = "http://localhost:8080/transactionProduct";

        public TransactionProductService()
        {
            client = new HttpClient();
        }


        public async Task<List<ReserveHistory>> getAllReserveHistory()
        {
            string message = await client.GetStringAsync(uri);
            List<ReserveHistory> returnList = JsonSerializer.Deserialize<List<ReserveHistory>>(message);
            return returnList;
        }

        public async Task<List<ReserveHistory>> getReserveHistoryByStoreEmail(int storeid, string email)
        {
            string message = await client.GetStringAsync(uri + "/" + storeid + "/" + email);
            List<ReserveHistory> returnList = JsonSerializer.Deserialize<List<ReserveHistory>>(message);
            return returnList;
        }

        public async Task<List<ReserveHistory>> getReserveHistoryByStoreEmailDelivery(int storeid, string email, string delivery)
        {
            string message = await client.GetStringAsync(uri + "/" + storeid + "/" + email + "/" + delivery);
            List<ReserveHistory> returnList = JsonSerializer.Deserialize<List<ReserveHistory>>(message);
            return returnList;
        }
    }
}
