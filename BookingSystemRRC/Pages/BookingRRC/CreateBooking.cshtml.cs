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


        // For at kunne bruge Booking Service og Listen af g�ster, kr�ver det en reference til Services.BookingService.cs
        private GuestService guestService;
        private BookingService bookingService;
        private List<Models.Booking> bookings;

        [BindProperty]
        public Models.Booking Booking { get; set; } = new Models.Booking();
        [BindProperty]
        public Models.Guest Guest { get; set; } = new Models.Guest();

        

        public CreateBookingModel(BookingService bookingService, GuestService guestService)
        {
            this.bookingService = bookingService;
            this.guestService = guestService;
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
            await guestService.CreateGuestAsync(Guest);
            //Booking.GuestNumber = Guest.GuestNumbe;
            await bookingService.CreateBookingAsync(Booking);
            return RedirectToPage("/BookingRRC/BookingAcceptance");
        }
    }
}
