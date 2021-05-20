using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class Timeslot
    {

        public int TimeId { get; set; }

        public string StartTime { get; set; }
        public string EndTime { get; set; }

        public Timeslot()
        {

        }

        public Timeslot(string stratTime, string endTime)
        {
            StartTime = stratTime;
            EndTime = endTime;
        }


    }
}
