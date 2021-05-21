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
        private GuestService guestService;
        private List<Models.Booking> bookings;
        private List<Models.Guest> guests;

        [BindProperty]
        public Models.Booking Booking { get; set; }
        [BindProperty]
        public Models.Guest Guest { get; set; }

        public CreateBookingModel(BookingService bookingService, GuestService guestService)
        {
            this.bookingService = bookingService;
            this.guestService = guestService;
            bookings = bookingService.GetBookings().ToList();
            guests = guestService.GetGuests().ToList();
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
            await guestService.CreateGuestAsync(Guest);
            return RedirectToPage("/BookingRRC/BookingAcceptance");
        }
    }
}
