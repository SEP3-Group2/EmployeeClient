using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public class CloudUserService : IUserService
    {
        HttpClient client;
        string uri = "http://localhost:8080/employeeUsers";

        public CloudUserService()
        {
            client = new HttpClient();
        }

        public async Task AddUserAsync(User user)
        {
            string userSerialized = JsonSerializer.Serialize(user);

            HttpContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
                );

            await client.PostAsync($"{uri}", content);
        }

        public async Task<User> ValidateUser(string email, string password)
        {
            string message = await client.GetStringAsync($"{uri}/{email}");

            User result = JsonSerializer.Deserialize<User>(message);

            if (result == null)
            {
                throw new Exception("User not found");
            }

            if (!result.Password.Equals(password))
            {
                throw new Exception("Password is incorrect");
            }

            return result;
        }
    }
}
