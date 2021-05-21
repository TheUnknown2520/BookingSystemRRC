using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using Microsoft.AspNetCore.Identity;

namespace BookingSystemRRC.MockData
{
    public class MockUser
    {
        private static PasswordHasher<string> passwordHasher = new PasswordHasher<string>();

        private static List<User> users = new List<User>()
        {
            new User("Jesper", passwordHasher.HashPassword(null, "admin")),
            new User("Caroline", passwordHasher.HashPassword(null, "kode")),
            new User("Frederikke", passwordHasher.HashPassword(null, "123")),
            new User("Christoffer", passwordHasher.HashPassword(null,"321"))
        };

        public static List<User> GetMockUsers()
        {
            return users;
        }
    }
}
