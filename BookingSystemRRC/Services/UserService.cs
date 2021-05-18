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

        public DbService DbService { get; set; }
        public UserService(DbService dbService)
        {
            DbService = dbService;
            Users = MockUser.GetMockUsers();
            //DbService.SaveUsers(Users);
            //Users = dbService.GetBookings().Result.ToList();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }
    }
}
