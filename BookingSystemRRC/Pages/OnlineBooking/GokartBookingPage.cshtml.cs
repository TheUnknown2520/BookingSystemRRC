using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;

namespace BookingSystemRRC.Pages.OnlineBooking
{
    public class GokartBookingPageModel : PageModel
    {
        private BookingService bookingService;
        private GuestService guestService;
        private List<Models.Booking> bookings;
        private List<Models.Guest> guests;

        [BindProperty]
        public Models.Booking Booking { get; set; } = new Models.Booking();
        [BindProperty]
        public Models.Guest Guest { get; set; }

        //[BindProperty]
        //public string Type { get; set; }

        public GokartBookingPageModel(BookingService bookingService, GuestService guestService)
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
            return RedirectToPage("/OnlineBooking/Thanks");
        }

    }
}
