using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class BookingAcceptanceModel : PageModel
    {
        private BookingService bookingService;

        public List<Models.Booking> bookings { get; private set;}

        public BookingAcceptanceModel(BookingService bookingService)
        {
            this.bookingService = bookingService;
        }
        public IActionResult OnGet()
        {
            bookings = bookingService.GetBookings().ToList();
            return Page();
        }
    }
}
