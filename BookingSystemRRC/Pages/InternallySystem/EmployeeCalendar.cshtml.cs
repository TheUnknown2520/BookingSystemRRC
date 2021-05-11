using System;
using System.Collections.Generic;
using System.Linq;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BookingSystemRRC.Pages.InternallySystem
{
    public class EmployeeCalendarModel : PageModel
    {
        private BookingService bookingService;

        public List<Booking> bookings { get; private set; }


        public EmployeeCalendarModel(BookingService bookingService)
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
