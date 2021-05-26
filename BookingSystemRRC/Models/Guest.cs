using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class Guest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GuestNumbe { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string GuestComment { get; set; }
        public ICollection<Booking> Bookings { get; set; }
        public ICollection<RoomBooking> RoomBookings { get; set; }


        public static int NextGuestNumber = 100000;

        public Guest()
        {
            // Default Constructor (takes no parameters)
        }

        public Guest( string firstName, string lastName, string email, int phoneNumber, string nationality, string guestComment /*string createdBy*/)
        {
            GuestNumbe = NextGuestNumber++;
            FirstName = firstName ;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            GuestComment = guestComment;
            //CreatedBy = createdBy;
        }

    }

    
}
