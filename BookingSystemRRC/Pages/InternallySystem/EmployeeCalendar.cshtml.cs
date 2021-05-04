using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;
using BookingSystemRRC.MockData;

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
