using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


        public void OnGetMoveBookingLeft(int id)
        {
            bookingService.MoveBookingLeft(id);
            OnGet();
        }
        public void OnGetMoveBookingRight(int id)
        {
            bookingService.MoveBookingRight(id);
            OnGet();
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await bookingService.CreateBookingAsync(new Booking(10, 200, "", "fadøl", "Christopher", TimeSlotBooking.DaysOfWeek.Mon, DateTime.Now));

            return RedirectToPage("EmployeeCalendar");
        }




    }
}
