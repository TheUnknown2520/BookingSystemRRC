using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BookingSystemRRC.Pages.Booking;

namespace BookingSystemRRC.Pages.BookingFolder
{
    public class GokartBookingModel : PageModel
    {
        private readonly ILogger<GokartBookingModel> _logger;

        public GokartBookingModel(ILogger<GokartBookingModel> logger)
        {
            _logger = logger;
        }

        public Guest Guest { get; set; }
        public Booking Booking { get; set; }

        public void OnGet()
        {
            
        }
    }
}
