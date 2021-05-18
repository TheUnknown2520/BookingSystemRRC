using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BookingSystemRRC.Pages.BookingRRC
{
    public class DeleteBookingModel : PageModel
    {
        private BookingService bookingService;

        [BindProperty]
        public Models.Booking Booking { get; set; }

        public DeleteBookingModel(BookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        public IActionResult OnGet(int id)
        {
            Booking = bookingService.GetBooking(id);
            if (Booking == null)
                return RedirectToPage("/NotFound"); // er ikke lavet endnu
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            Booking = bookingService.GetBooking(id);
            bookingService.DeleteBookingAsync(Booking.BookingNumber);
            return RedirectToPage("/BookingRRC/BookingAcceptance");
        }
    }
}
