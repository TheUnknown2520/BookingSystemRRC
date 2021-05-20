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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GuestNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string GuestComment { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public ICollection<Booking> Bookings { get; set; }


        public static int NextGuestNumber = 100000;

        public Guest()
        {
            // Default Constructor (takes no parameters)
        }

        public Guest( string name, string email, int phoneNumber, string nationality, string guestComment, string createdBy)
        {
            GuestNumber = NextGuestNumber++;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            GuestComment = guestComment;
            CreatedBy = createdBy;
        }

    }

    
}
