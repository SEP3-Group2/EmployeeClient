using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public interface IUserService
    {
        User ValidateUser(string userName, string password);
        Task AddUserAsync(User user);
    }
}
