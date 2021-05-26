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
            new Booking( 10, "Firma", "Øl klar ved ankomst", "Christopher", WeekDays.Mandag, DateTime.Now, DateTime.Now),



            new Booking( 10,  "Firma", "Øl klar ved ankomst", "Christopher", WeekDays.Mandag,  DateTime.Now, DateTime.Now)
        };

        public static List<Booking> GetMockBookings()
        {
            return bookings;
        }

    }
}
