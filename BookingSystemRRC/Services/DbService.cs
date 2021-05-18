using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using Microsoft.EntityFrameworkCore;

namespace BookingSystemRRC.Services
{
    public class DbService
    {
        public async Task AddBooking(Booking booking)
        {
            using (var context = new BookingDbContext())
            {
                context.Bookings.Add(booking);
                context.SaveChanges();
            }
        }

        public async Task AddGuest(Guest guest)
        {
            using (var context = new BookingDbContext())
            {
                context.Guests.Add(guest);
                context.SaveChanges();
            }
        }

        

        public async Task SaveBooking(List<Booking> bookings)
        {
            using (var context = new BookingDbContext())
            {
                foreach(Booking booking in bookings)
                {
                    context.Bookings.Add(booking);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }

        public async Task SaveGuest(List<Booking> bookings)
        {
            using (var context = new BookingDbContext())
            {
                foreach (Booking booking in bookings)
                {
                    context.Bookings.Add(booking);
                    context.SaveChanges();
                }

                context.SaveChanges();
            }
        }


        public async Task<List<Booking>> GetBookings()
        {
            using (var context = new BookingDbContext())
            {
                return await context.Bookings.ToListAsync();
            }
        }

        public async Task<List<Guest>> GetGuests()
        {
            using (var context = new BookingDbContext())
            {
                return await context.Guests.ToListAsync();
            }
        }

    }
}
