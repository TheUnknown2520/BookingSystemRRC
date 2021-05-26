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

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingNumber { get; set; }
        [Required]
        public int NumberOfPeople { get; set; }
        //[Required]
        //public int TotalPrice { get; set; }
        public string Type { get; set; }
        [StringLength(100)]
        public string BookingComment { get; set; }
        public string CreatedBy { get; set; }
        [Required]
        public WeekDays WeekDays { get; set; }

        [Required]
        public DateTime DateTimeStart { get; set; }

        [Required]
        public DateTime DateTimeEnd { get; set; }

 
        [Required]
        public int GuestNumber { get; set; }
        public Guest Guest { get; set; }


        public static int Nextbookingnumber = 100000;



        public Booking() 
        {
            // Default Constructor (takes no parameters)
        }

        public Booking( int numberOfPeople, /*int totalprice,*/ string type, string bookingComemnt, string createdBy, WeekDays weekDays, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            BookingNumber = Nextbookingnumber++;
            NumberOfPeople = numberOfPeople;
            //TotalPrice = totalprice;
            Type = type;
            BookingComment = bookingComemnt;
            CreatedBy = createdBy;
            DateTimeStart = dateTimeStart;
            DateTimeEnd = dateTimeEnd;
        }
    }
}
