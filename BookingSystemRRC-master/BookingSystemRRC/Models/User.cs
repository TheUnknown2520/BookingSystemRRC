using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class User
    {
        [Key]
        [StringLength(20)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        public User()
        {

        }
        
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
