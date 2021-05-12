using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using BookingSystemRRC.MockData;

namespace BookingSystemRRC.Services
{
    public class BookingService
    {

        private List<Booking> bookings;

        public DbGenericService<Booking> DbService { get; set; }

        public BookingService(DbGenericService<Booking> dbService)
        {
            DbService = dbService;
            //bookings = MockBooking.GetMockBookings();
            //foreach (Booking booking in bookings)
            //{
            //    dbService.AddObjectAsync(booking);
            //}

            bookings = dbService.GetObjectsAsync().Result.ToList();
        }

        //henter en booking via dens booking nummer
        public Booking GetBooking(int bookingNumber)
        {
            foreach(Booking booking in bookings)
            {
                if  (booking.BookingNumber == bookingNumber)
                    return booking;
            }
            return null;
        }


        public IEnumerable<Booking> GetBookings()
        {
            return bookings;
        }

        #region CustomizeBookings

        //Opretter en booking
        public async Task CreateBookingAsync(Booking booking)
        {
            if (!(bookings.Contains(booking)))
            {
                bookings.Add(booking);
                await DbService.AddObjectAsync(booking);
            }
        }
        // retuner hele listen med alle bookings
        

        

        //Sletter en booking ud fra booking nr
        public async Task DeleteBookingAsync(int bookingNumber)
        {
            Booking bookingToBeDeleted = bookings.Find(booking => booking.BookingNumber == bookingNumber);
            //foreach(Booking b in bookings)
            //{
            //    if(b.BookingNumber == bookingNumber)
            //    {
            //        bookingToBeDeleted = b;
            //        break;
            //    }
            //}
            if(bookingToBeDeleted != null)
            {
                bookings.Remove(bookingToBeDeleted);
                 await DbService.DeleteObjectAsync(bookingToBeDeleted);
            }
             
        }
        
        //Opdaterer/redigerer en booking
        // b. = nye booking
        public void UpdateBooking(Booking booking)
        {
            if(booking != null)
            {
                foreach (Booking b in bookings)
                {
                    if (b.BookingNumber == booking.BookingNumber)
                    {
                        b.CreatedBy = booking.CreatedBy;
                        b.NumberOfPeople = booking.NumberOfPeople;
                        b.TotalPrice = b.TotalPrice;
                        b.BookingComment = booking.BookingComment;
                        b.Type = booking.Type;
                    }
                }

                DbService.UpdateObjectAsync(booking);
               
            }
        }

#endregion

    }
}
