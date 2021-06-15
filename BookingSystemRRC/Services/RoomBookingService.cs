using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Services
{
    public class RoomBookingService
    {
        private List<RoomBooking> RoomBookings;

        public DbGenericService<RoomBooking> DbService { get; set; }

        public RoomBookingService(DbGenericService<RoomBooking> dbService)
        {
            DbService = dbService;
            

        }

        public RoomBooking GetRoomBooking(int RoomBookinId)
        {
            foreach (RoomBooking roomBooking in RoomBookings)
            {
                if (roomBooking.RoomBookingNumber == RoomBookinId)
                    return roomBooking;
            }
            return null;
        }


        public IEnumerable<RoomBooking> GetRoomBookings()
        {
            return RoomBookings;
        }




        public async Task CreateRoomBookingAsync(RoomBooking roomBooking)
        {
            if (!(RoomBookings.Contains(roomBooking)))
            {
                RoomBookings.Add(roomBooking);
                await DbService.AddObjectAsync(roomBooking);
            }
        }





        public async Task DeleteRoomBookingAsync(int roomBookingNumber)
        {
            RoomBooking RoomBookingToBeDeleted = RoomBookings.Find(roomBooking => roomBooking.RoomBookingNumber == roomBookingNumber);

            if (RoomBookingToBeDeleted != null)
            {
                RoomBookings.Remove(RoomBookingToBeDeleted);
                await DbService.DeleteObjectAsync(RoomBookingToBeDeleted);
            }

        }
    }
}
