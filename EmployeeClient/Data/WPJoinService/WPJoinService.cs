using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public class WPJoinService : IWPJoinService
    {
        private string uri = "http://localhost:8080";
        private readonly HttpClient client;

        public WPJoinService()
        {
            this.client = new HttpClient();
        }
        public async Task<List<WPJoin>> GetAllWPJoinAsync()
        {
            string message = await client.GetStringAsync(uri + "/wpjoin");
            List<WPJoin> returnList = JsonSerializer.Deserialize<List<WPJoin>>(message);
            Console.WriteLine(returnList.ToString()); 

            return returnList;
        }

        public async Task<List<WPJoin>> GetStoreWPJoinAsync(int storeid)
        {
            string message = await client.GetStringAsync(uri + "/wpjoin/" + storeid);
            List<WPJoin> returnList = JsonSerializer.Deserialize<List<WPJoin>>(message);

            return returnList;
        }
    }
}
