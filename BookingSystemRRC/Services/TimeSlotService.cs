//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using BookingSystemRRC.Models;

//namespace BookingSystemRRC.Services
//{
//    public class TimeSlotService
//    {
//        public List<Timeslot> timeSlotList { get; set; }

//        public DbGenericService<Timeslot> Dbservice { get; set; }

//        public TimeSlotService(DbGenericService<Timeslot> dbService)
//        {
//            Dbservice = dbService;
//            timeSlotList = Dbservice.GetObjectsAsync().Result.ToList();
//        }


//        public async void AddTimeSlotToBooking(Timeslot timeslot)
//        {
//            timeSlotList.Add(timeslot);
//            await Dbservice.AddObjectAsync(timeslot);
//        }


//    }
//}
