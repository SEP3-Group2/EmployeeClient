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
        private int userID = 0;

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

        public async Task<List<User>> GetAllUsersAsync()
        {
            string message = await client.GetStringAsync(uri);
            List<User> returnList = JsonSerializer.Deserialize<List<User>>(message);

            return returnList;
        }

        public void SetUserID(int id)
        {
            userID = id;
        }

        public int GetUserID()
        {
            return userID;
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

        public async Task<User> GetUserByIDAsync(int id)
        {
            string message = await client.GetStringAsync($"{uri}/users/{id}");
            User result = JsonSerializer.Deserialize<User>(message);
            return result;
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            string userSerialized = JsonSerializer.Serialize(user);

            HttpContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
                );

            await client.PatchAsync(uri, content);
            var returnUser = await GetUserByIDAsync(user.UserID);
            Console.WriteLine($"Received user with phone: {user.Contact}");
            return returnUser;
        }

        public async Task DeleteUserAsync(int id)
        {
            await client.DeleteAsync($"{uri}/deleteEmployee/{id}");
        }
    }
}
