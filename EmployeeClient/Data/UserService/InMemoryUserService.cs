using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[] {
                new User {
                    Password = "123456",
                    Position = "Manager",
                    SecurityLevel = 5,
                    Email = "Anett"
                },
                new User {
                    Password = "123456",
                    Position = "HR",
                    SecurityLevel = 4,
                    Email = "Christian"
                },
                new User {
                    Password = "123456",
                    Position = "Warehouse operative",
                    SecurityLevel = 3,
                    Email = "Kianoush"
                },
                new User {
                    Password = "123456",
                    Position = "Shelf-stacker",
                    SecurityLevel = 2,
                    Email = "Kevin"
                },
                new User {
                    Password = "123456",
                    Position = "Cashier",
                    SecurityLevel = 1,
                    Email = "Ole"
                },
            }.ToList();
        }

        public Task AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetUserID()
        {
            throw new NotImplementedException();
        }

        public Task SetUserID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> UpdateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.Email.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        int IUserService.GetUserID()
        {
            throw new NotImplementedException();
        }

        void IUserService.SetUserID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
