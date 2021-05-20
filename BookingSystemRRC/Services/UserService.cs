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
        public List<User> Users { get; set; }

        public DbGenericService<User> DbService { get; set; }
        public UserService(DbGenericService<User> dbService)
        {
            DbService = dbService;
            Users = MockUser.GetMockUsers();
            //Users = DbService.GetObjectsAsync().Result.ToList();
            //DbService.SaveUsers(Users);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            DbService.AddObjectAsync(user);
        }
    }
}
