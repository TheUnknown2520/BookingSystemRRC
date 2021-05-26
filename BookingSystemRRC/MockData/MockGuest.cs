using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.MockData
{
    public class MockGuest
    {
        private static List<Guest> guests = new List<Guest>()
        {
            new Guest("bo", "Larsen", "bo@mail.dk", 12345678, "danmark","test"),
             new Guest("bob", "larsen", "bob@mail.dk", 87654321, "danmark","test")

        };

        public static List<Guest> GetMockGuests()
        {
            return guests;
        }
    }
}
