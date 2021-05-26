using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using BookingSystemRRC.MockData;

namespace BookingSystemRRC.Services
{
    public class GuestService
    {
        private List<Guest> guests;

        //public DbGenericService<Guest> DbService { get; set; }

        public DbGenericService<Guest> DbService { get; set; }

        public GuestService(DbGenericService<Guest> dbService )
        {
            DbService = dbService;
            //guests = MockGuest.GetMockGuests();
            //foreach (Guest guest in guests)
            //{
            //    dbService.AddObjectAsync(guest);
            //}
            guests = DbService.GetObjectsAsync().Result.ToList();
        }


        public Guest GetGuests(int guestNumber)
        {
            foreach (Guest guest in guests)
            {
                if (guest.GuestNumbe == guestNumber)
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
            Guest GuestToBeDeleted = guests.Find(guest => guest.GuestNumbe == guestNumber);
           
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
                    if (g.GuestNumbe == guest.GuestNumbe)
                    {
                        g.FirstName = guest.FirstName;
                        g.LastName = guest.LastName;
                        g.PhoneNumber = guest.PhoneNumber;
                        g.Email = guest.Email;
                        g.Nationality = guest.Nationality;

                    }
                }

                await DbService.UpdateObjectAsync(guest);

            }
        }

        public IEnumerable<Guest> NameSearch(string str)
        {
            if (string.IsNullOrEmpty(str)) return guests;
            return from guest in guests where guest.FirstName.ToLower().Contains(str.ToLower()) select guest;

        }

      
    }

}
