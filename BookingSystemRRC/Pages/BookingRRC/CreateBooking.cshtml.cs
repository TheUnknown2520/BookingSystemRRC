using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class CreateBookingModel : PageModel
    {


        // For at kunne bruge Booking Service og Listen af gæster, kræver det en reference til Services.BookingService.cs
        private BookingService bookingService;
        private List<Models.Booking> bookings;
        private List<Models.Guest> Guests;

        [BindProperty]
        public Models.Booking Booking { get; set; } = new Models.Booking();
        [BindProperty]
        public Models.Guest Guest { get; set; }

        [BindProperty]
        public string Type { get; set; }

        public CreateBookingModel(BookingService bookingService)
        {
            this.bookingService = bookingService;
            bookings = bookingService.GetBookings().ToList();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
           await bookingService.CreateBookingAsync(Booking);
            return RedirectToPage("/BookingRRC/BookingAcceptance");
        }
    }
}
