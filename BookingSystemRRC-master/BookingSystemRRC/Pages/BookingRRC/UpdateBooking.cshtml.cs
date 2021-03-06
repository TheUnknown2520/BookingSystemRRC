using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class UpdateBookingModel : PageModel
    {
        private BookingService bookingService;

        public Models.Booking Booking { get; set; }

        public UpdateBookingModel(BookingService bookingService)
        {
            this.bookingService = bookingService;

        }

        public IActionResult OnGet(int id)
        {
            Booking = bookingService.GetBooking(id);
            return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            bookingService.UpdateBooking(Booking);
            return RedirectToPage("/BookingRRC/BookingAcceptance");
        }
     
    }
}
