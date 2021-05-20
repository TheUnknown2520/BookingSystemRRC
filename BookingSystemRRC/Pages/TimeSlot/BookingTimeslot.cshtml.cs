using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Pages.TimeSlot
{
    public class BookingTimeslotModel : PageModel
    {
        private BookingService bookingService;
        private TimeSlotService timeSlotService;

        [BindProperty]
        public Models.Booking booking { get; set; }

        public Models.Booking Booking { get; set; } = new Models.Booking();

        public void OnGet(BookingService bookingService, TimeSlotService timeSlotService)
        {
            this.timeSlotService = timeSlotService;
            this.bookingService = bookingService ; 
        }
    }
}
