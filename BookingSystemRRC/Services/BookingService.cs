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

        // retuner hele listen med alle bookings
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
      
       

        //Sletter en booking ud fra booking nr
        public async Task DeleteBookingAsync(int bookingNumber)
        {
            Booking bookingToBeDeleted = bookings.Find(booking => booking.BookingNumber == bookingNumber);
           
            if(bookingToBeDeleted != null)
            {
                bookings.Remove(bookingToBeDeleted);
                 await DbService.DeleteObjectAsync(bookingToBeDeleted);
            }
             
        }
        
        //Opdaterer/redigerer en booking
        // b. = nye booking
        public async Task UpdateBookingAsync(Booking booking)
        {
            if(booking != null)
            {
                foreach (Booking b in bookings)
                {
                    if (b.BookingNumber == booking.BookingNumber)
                    {
                        b.CreatedBy = booking.CreatedBy;
                        b.NumberOfPeople = booking.NumberOfPeople;
                        //b.TotalPrice = b.TotalPrice;
                        b.BookingComment = booking.BookingComment;
                        b.Type = booking.Type;
                        b.WeekDays = booking.WeekDays;
                        b.DateTimeStart = booking.DateTimeStart;
                        b.DateTimeEnd = booking.DateTimeEnd;
                    }
                }

                   await DbService.UpdateObjectAsync(booking);
               
            }
        }

        #endregion


        public async Task MoveBookingLeft(int id)
        {
            Booking booking = GetBooking(id);
            booking.WeekDays--;
            await DbService.UpdateObjectAsync(booking);
        }

        public async Task MoveBookingRight(int id)
        {
            Booking booking = GetBooking(id);
            booking.WeekDays++;
            await DbService.UpdateObjectAsync(booking);
        }


        public IEnumerable<Booking> SortByID()
        {
            return from Booking in bookings
                   orderby Booking.BookingNumber
                   select Booking;
        }

        public IEnumerable<Booking> SortByIDDescending()
        {
            return from Booking in bookings
                   orderby Booking.BookingNumber descending
                   select Booking;
        }
    }
}
