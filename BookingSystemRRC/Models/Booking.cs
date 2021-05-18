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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookingNumber { get; set; }
        [Required]
        //[StringLength(2)]
        public int NumberOfPeople { get ; set; }
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public string Type { get; set; }
        [StringLength(100)]
        public string BookingComment { get; set; }
        [Required]
        public string CreatedBy { get; set; }

        public Guest Guest { get; set; }


        public static int Nextbookingnumber = 100000;

        public Booking()
        {
            // Default Constructor (takes no parameters)
        }

        public Booking( int numberOfPeople, int totalprice, string type, string bookingComemnt, string createdBy)
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
