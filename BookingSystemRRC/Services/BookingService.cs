using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Services
{
    public class BookingService
    {

        private List<Booking> bookings;

        

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
        public IEnumerable<Booking> GetBookings()
        {
            return bookings;
        }

        

        //Sletter en booking ud fra booking nr
        public Booking DeleteBooking(int bookingNumber)
        {
            Booking bookingToBeDeleted = null;
            foreach(Booking booking in bookings)
            {
                if(booking.BookingNumber == bookingNumber)
                {
                    bookingToBeDeleted = booking;
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
                        b.BookingComment = booking.BookingComment;
                        b.CreatedBy = booking.CreatedBy;
                    }
                }
            }
        }

#endregion


    }
}
