using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookingSystemRRC.Models
{
    public class BookingDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            {
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookingDB; Integrated Security=True; Connect Timeout=30; Encrypt=False");
            }

            public DbSet<Booking> Bookings { get; set; }
            public DbSet<Guest> Guests { get; set; }
            public DbSet<Guest> Users { get; set; }
    }
}
