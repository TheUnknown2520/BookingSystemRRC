using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class UpdateBookingModel : PageModel
    {
        private BookingService bookingService;

        [BindProperty]
        public Models.Booking Booking { get; set; }
       

        public UpdateBookingModel(BookingService bookingService)
        {
            this.bookingService = bookingService;
        }

        public IActionResult OnGet(int id)
        {
            Booking = bookingService.GetBooking(id);
            if (Booking == null)
                return RedirectToPage("/NotFound");

            return Page();

        }

        public async Task<IActionResult> OnPost(int id)
        {
            //Booking = bookingService.GetBooking(id);
            if (!ModelState.IsValid)
            {
               
                return Page();
            }

            await bookingService.UpdateBookingAsync(Booking);
            return RedirectToPage("/BookingRRC/BookingAcceptance");

        }

    }
}
