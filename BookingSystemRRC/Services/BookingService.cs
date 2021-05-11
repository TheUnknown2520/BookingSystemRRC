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

        public DbService DbService { get; set; }

        public BookingService(DbService dbService)
        {
            DbService = dbService;
            //bookings = MockBooking.GetMockBookings();
            //foreach(Booking booking in bookings)
            //{
            //    dbService.AddBooking(booking);
            //}

            bookings = dbService.GetBookings().Result;
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
        public void CreateBooking(Booking booking)
        {
            if (!(bookings.Contains(booking)))
            {
                bookings.Add(booking);
            }
        }
        // retuner hele listen med alle bookings
        

        

        //Sletter en booking ud fra booking nr
        public Booking DeleteBooking(int bookingNumber)
        {
            Booking bookingToBeDeleted = null;
            foreach(Booking b in bookings)
            {
                if(b.BookingNumber == bookingNumber)
                {
                    bookingToBeDeleted = b;
                    break;
                }
            }
            if(bookingToBeDeleted != null)
            {
                bookings.Remove(bookingToBeDeleted);
               
            }
            return bookingToBeDeleted; 
        }
        
        //Opdaterer/redigerer en booking
        // b. = nye booking
        public void UpdateBooking(Booking booking)
        {
            if(booking != null)
            {
                foreach(Booking b in bookings)
                {
                    if(b.BookingNumber == booking.BookingNumber)
                    {
                       
                        b.CreatedBy = booking.CreatedBy;
                        b.NumberOfPeople = booking.NumberOfPeople;
                        b.TotalPrice = b.TotalPrice;
                        b.BookingComment = booking.BookingComment;
                        b.Type = booking.Type;

                    }

                    
                }

                DbService.
               
            }
        }

#endregion

    }
}
