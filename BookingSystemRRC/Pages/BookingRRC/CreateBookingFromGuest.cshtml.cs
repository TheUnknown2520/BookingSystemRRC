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
    public class CreateBookingFromGuestModel : PageModel
    {
        private BookingService bookingService;
        private GuestService guestService;

        public Guest Guest { get; set; }
        [BindProperty]
        public Models.Booking Booking { get; set; } = new Models.Booking();
        public int GuestNumbe { get; set; }
        public void OnGet(BookingService bookingService, GuestService guestService)
        {
            this.bookingService = bookingService;
            this.guestService = guestService;
        }

        //public void OnGet(int id)
        //{
        //    Guest = guestService.GetGuest(id);
        //    //Booking.GuestNumbe = id;
        //    //return Page();
        //}

        //public IActionResult OnPostAsync(int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }
        //    Booking.GuestNumbe = id;
        //    Guest = guestService.GetGuest(id);
        //    //booking.GuestNumbe = GuestNumbe;
        //    Booking.GuestNumbe = Guest.GuestNumbe;
        //    bookingService.CreateBookingAsync(Booking);
        //    return RedirectToPage("/BookingRRC/GetAllOrders");
        //}
    }
}
