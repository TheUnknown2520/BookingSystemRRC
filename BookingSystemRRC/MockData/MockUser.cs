using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.MockData
{
    public class MockUser
    {
        private static List<User> users = new List<User>()
        {
            new User("Caroline", "kode"),
            new User("Frederikke", "123"),
            new User("Christoffer", "321")
        };

        public static List<User> GetMockUsers()
        {
            return users;
        }
    }
}
