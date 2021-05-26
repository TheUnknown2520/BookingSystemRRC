using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class RoomBooking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomBookingNumber { get; set; }
        [Required]
        public WeekDays WeekDay { get; set; }

        public RoomBooking()
        {

        }

        public RoomBooking(WeekDays weekDays)
        {
                
        }


    }
}
