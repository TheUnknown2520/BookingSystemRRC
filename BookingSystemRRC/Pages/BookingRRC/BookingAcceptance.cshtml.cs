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
        private GuestService guestService;
        

        public List<Models.Booking> bookings { get; private set;}

        public List<Models.Guest> Guests { get; private set; }

        public BookingAcceptanceModel(BookingService bookingService, GuestService guestService)
        {
            this.bookingService = bookingService;
            this.guestService = guestService;

        }
        public IActionResult OnGet()
        {
            bookings = bookingService.GetBookings().ToList();
            Guests = guestService.GetGuests().ToList();
            return Page();
        }

        public IActionResult OnGetSortById()
        {
            bookings = bookingService.SortByID().ToList();
            return Page();
        }
        public IActionResult OnGetSortByIdDescending()
        {
            bookings = bookingService.SortByIDDescending().ToList();
            return Page();
        }
    }
}
