using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class Booking
    {

        public int BookingNumber { get; set; }
        public int NumberOfPeople { get ; set; }
        public int TotalPrice { get; set; }
        public string Type { get; set; }
        public string BookingComment { get; set; }


        public string CreatedBy { get; set; }


        public Booking()
        {
            // Default Constructor (takes no parameters)
        }

        public Booking(int bookingNumber, int numberOfPeople, int totalprice, string type, string bookingComemnt, string createdBy)
        {
            BookingNumber = bookingNumber;
            NumberOfPeople = numberOfPeople;
            TotalPrice = totalprice;
            Type = type;
            BookingComment = bookingComemnt;
            CreatedBy = createdBy; 
        }
    }
}
