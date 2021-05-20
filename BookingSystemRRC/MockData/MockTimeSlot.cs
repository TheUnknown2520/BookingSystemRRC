using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

//new TimeSlotGokart(GetDateTime(2021, 05, 01, 09.5), GetDateTime(2021, 05, 01, 10), 26)

namespace BookingSystemRRC.MockData
{
    public class MockTimeSlot
    {

        private List<TimeSlotBooking> timeSlots = new List<TimeSlotBooking>();
        
        public MockTimeSlot()
        {
            var startDtGen = new DateTime(2021, 05, 01);
            var endDtGen = new DateTime(2021, 12, 31);

            

            var startTimeGen = GetDateTime(2021, 05, 1, 09);
        }

        public List<TimeSlotBooking> GetMockTimeSlots()
        {

            return timeSlots;
        }

        private static DateTime GetDateTime(int year, int month, int day, double timeOfDay)
        {
            var dt = new DateTime(year, month, day);
            dt.AddHours(timeOfDay);

            return dt;
        }

    }
}
