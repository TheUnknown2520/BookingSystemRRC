using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.MockData
{
    public class MockBooking
    {

        private static List<Booking> bookings = new List<Booking>()
        {
            new Booking(0, 10, 1500, "Firma", "Øl klar ved ankomst", "Christopher")
        };

        public static List<Booking> GetMockBookings()
        {
            return bookings;
        }

    }
}
