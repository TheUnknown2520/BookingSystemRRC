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

        public GuestService( DbGenericService<Guest> dbService )
        {
            DbService = dbService; 
        }




    }

}
