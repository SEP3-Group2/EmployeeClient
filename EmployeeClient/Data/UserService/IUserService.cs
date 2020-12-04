using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public interface IUserService
    {
        Task<User> ValidateUser(string userName, string password);
        Task AddUserAsync(User user);
        void SetUserID(int id);
        int GetUserID();
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIDAsync(int id);
        Task<User> UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
