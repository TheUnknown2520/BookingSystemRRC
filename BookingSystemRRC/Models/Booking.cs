using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class Booking
    {
        //The derived type 'Booking' cannot have the [Key] attribute on property 'BookingNumber' since primary keys may only be declared on the root type.
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingNumber { get; set; }
        [Required]
        //[StringLength(2)]
        public int NumberOfPeople { get; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public string Type { get; set; }
        [StringLength(100)]
        public string BookingComment { get; set; }
        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public TimeSlotBooking.DaysOfWeek WeekDays { get; set; }

        [Required]
        public DateTime DateTime { get; set; }


        public Guest Guest { get; set; }


        public static int Nextbookingnumber = 100000;



        public Booking() 
        {
            // Default Constructor (takes no parameters)
        }

        public Booking( int numberOfPeople, int totalprice, string type, string bookingComemnt, string createdBy, TimeSlotBooking.DaysOfWeek weekDays, DateTime dateTime)
        {
            BookingNumber = Nextbookingnumber++;
            NumberOfPeople = numberOfPeople;
            TotalPrice = totalprice;
            Type = type;
            BookingComment = bookingComemnt;
            CreatedBy = createdBy;
            
        }


    }

}
