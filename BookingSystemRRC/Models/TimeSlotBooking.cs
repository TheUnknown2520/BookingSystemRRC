using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class TimeSlotBooking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeSlotId { get; set; }

        
        public enum DaysOfWeek
        {
            Mon,
            Tue,
            Wed,
            Thu,
            Fri,
            Sat,
            Sun
        }

        [Required]
        public DaysOfWeek WeekDays { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        public TimeSlotBooking()
        {
            // Default Con
        }


        public TimeSlotBooking(DaysOfWeek weekDays, DateTime dateTime ) 
        {
            WeekDays = weekDays;
            DateTime = dateTime;
        }

    }
}
