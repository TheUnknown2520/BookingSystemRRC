using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class GokartBookingModel : PageModel
    {
        public Guest Guest { get; set; }
        public Booking Booking { get; set; }

        public void OnGet()
        {

            

        }
    }
}
