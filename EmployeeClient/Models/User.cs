using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmployeeClient.Models
{
    public class User
    {
        [JsonPropertyName("userID")]
        public int UserID { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("phone")]
        public string Contact { get; set; }

        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("storeID")]
        public int StoreID { get; set; }

        public bool Equals(User user)
        {
            return UserID == user.UserID &&
                   Password == user.Password &&
                   Email == user.Email &&
                   Name == user.Name &&
                   Address == user.Address &&
                   Contact == user.Contact &&
                   SecurityLevel == user.SecurityLevel &&
                   Position == user.Position &&
                   StoreID == user.StoreID;
        }
    }
}
