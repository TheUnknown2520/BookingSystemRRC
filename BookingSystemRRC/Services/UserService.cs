using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.MockData;
using BookingSystemRRC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingSystemRRC.Services
{
    public class UserService
    {
        public List<User> users { get; set; }

        public DbGenericService<User> DbService { get; set; }
        public UserService(DbGenericService<User> dbService)
        {
            DbService = dbService;
            users = MockUser.GetMockUsers();
            //users = DbService.GetObjectsAsync().Result.ToList();
            
        }

        public void AddUser(User user)
        {
            users.Add(user);
            DbService.AddObjectAsync(user);
        }

        public User GetUsers(string username)
        {
            return users.Find(user => user.Username == username);
        }

        public IEnumerable<User> GetUsers()
        {
            return users;
        }




    }
}
