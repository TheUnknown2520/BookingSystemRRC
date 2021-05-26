using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Services
{
    public class BookingDbService : DbGenericService<BookingService>
    {
        //public async Task<Guest> GetBookingByGuestIdAsync(int id)
        //{
        //    Guest guest; 
        //    using (var context = new BookingDbContext())
        //    {
        //        guest = context.Guests
        //            .Include(b => b.Bookings)
        //            .AsNoTracking()
        //            .FirstOrDefault(g => g.GuestNumbe == id);
        //    }

        //    return guest;
        //}
    }
}
