using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class CreateBookingModel : PageModel
    {


        // For at kunne bruge Booking Service og Listen af gæster, kræver det en reference til Services.BookingService.cs
        private BookingService bookingService;
        private List<Guest> bookings;



        [BindProperty]
        public Guest Guest { get; set; }
        public Booking Booking { get; set; }



        public void OnGet()
        {



        }


    }
}
