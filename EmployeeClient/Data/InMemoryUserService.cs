using EmployeeClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeClient.Data
{
    public class InMemoryUserService:IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[] {
                new User {
                    Password = "123456",
                    Role = "Manager",
                    SecurityLevel = 5,
                    UserName = "Anett"
                },
                new User {
                    Password = "123456",
                    Role = "HR",
                    SecurityLevel = 4,
                    UserName = "Christian"
                },
                new User {
                    Password = "123456",
                    Role = "Warehouse operative",
                    SecurityLevel = 3,
                    UserName = "Kianoush"
                },
                new User {
                    Password = "123456",
                    Role = "Shelf-stacker",
                    SecurityLevel = 2,
                    UserName = "Kevin"
                },
                new User {
                    Password = "123456",
                    Role = "Cashier",
                    SecurityLevel = 1,
                    UserName = "Ole"
                },
            }.ToList();
        }


        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
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
    }
}
