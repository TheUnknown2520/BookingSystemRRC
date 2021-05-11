using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class TimeSlotGokart
    {

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int MaxAmountOfGokarts { get; set; }

        public TimeSlotGokart(DateTime startTime, DateTime endTime, int maxAmountOfGokarts)
        {
            StartTime = startTime;
            EndTime = endTime;
            MaxAmountOfGokarts = maxAmountOfGokarts;
        }

        public TimeSlotGokart()
        {
        }
    }
}
