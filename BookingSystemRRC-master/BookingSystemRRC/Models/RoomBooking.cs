using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BookingSystemRRC.Models
{
    public class RoomBooking
    {
        [Key]
        public int RoomId { get; set; }
    }
}
