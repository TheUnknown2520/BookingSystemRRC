using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Services
{
    public class GuestService
    {
        private List<Guest> guests;

        public DbGenericService<Guest> DbService { get; set; }

        public GuestService(DbGenericService<Guest> dbService )
        {
            DbService = dbService;
            guests = DbService.GetObjectsAsync().Result.ToList();
        }


        public Guest GetGuests(int guestNumber)
        {
            foreach (Guest guest in guests)
            {
                if (guest.GuestNumber == guestNumber)
                    return guest;
            }
            return null;
        }


        public IEnumerable<Guest> GetGuests()
        {
            return guests;
        }

       

     
        public async Task CreateGuestAsync(Guest guest)
        {
            if (!(guests.Contains(guest)))
            {
                guests.Add(guest);
                await DbService.AddObjectAsync(guest);
            }
        }

      



        public async Task DeleteGuestAsync(int guestNumber)
        {
            Guest GuestToBeDeleted = guests.Find(guest => guest.GuestNumber == guestNumber);
           
            if (GuestToBeDeleted != null)
            {
                guests.Remove(GuestToBeDeleted);
                await DbService.DeleteObjectAsync(GuestToBeDeleted);
            }

        }

      
        public async Task UpdateGuestAsync(Guest guest)
        {
            if (guest != null)
            {
                foreach (Guest g in guests)
                {
                    if (g.GuestNumber == guest.GuestNumber)
                    {
                        g.Name = guest.Name;

                    }
                }

                await DbService.UpdateObjectAsync(guest);

            }
        }

    }

}
