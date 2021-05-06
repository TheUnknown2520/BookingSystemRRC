using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class Guest
    {
        public int GuestNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Nationality { get; set; }
        public string GuestComment { get; set; }
        public string CreatedBy { get; set; }


        public Guest()
        {
            // Default Constructor (takes no parameters)
        }

        public Guest(int guestNumber, string name, string address, string email, int phoneNumber, string nationality, string guestComment, string createdBy)
        {
            GuestNumber = guestNumber;
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            GuestComment = guestComment;
            CreatedBy = createdBy;
        }

    }

    
}
