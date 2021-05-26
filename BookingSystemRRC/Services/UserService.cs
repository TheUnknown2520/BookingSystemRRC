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
            //users = MockUser.GetMockUsers();
            users = DbService.GetObjectsAsync().Result.ToList();
            //DbService.SaveUsers(users);

            //foreach (User user in users)
            //{
            //    DbService.AddObjectAsync(user);
            //}
        }

        public async Task AddUserAsync(User user)
        {
            users.Add(user);
            await DbService.AddObjectAsync(user);
        }

        public async Task DeleteUserAsync(User user)
        {
            users.Remove(user);
            await DbService.DeleteObjectAsync(user);
        }
        

        public User GetUser(int id)
        {
            //foreach (User user in users)
            //{
            //    if (user.Username == username)
            //        return user;
            //}
            //return null;
            return users.Find(user => user.Id == id);
        }


        public IEnumerable<User> GetUsers()
        {
            return users;
        }
    }
}
