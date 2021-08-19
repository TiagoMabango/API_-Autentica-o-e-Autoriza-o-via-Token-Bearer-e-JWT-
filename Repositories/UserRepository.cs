using System.Collections.Generic;
using System.Linq;
using Shop.Models;
namespace Shop.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username,string password)
        {
            var users = new List<User>();
            users.Add(new User {Id = 1, Username = "tiago", Password = "tiago", Role = "manager"});
            users.Add(new User {Id = 2, Username = "mabango", Password = "mabango", Role = "employee"});
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password).FirstOrDefault<User>();
        }
    }
}