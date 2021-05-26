using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Pages.OnlineBooking
{
    public class RoomBookingPageModel : PageModel
    {
        private RoomBookingService _roomBookingService;

        private List<RoomBooking> roomBookings;

        [BindProperty]
        public RoomBooking RoomBooking { get; set; }

        [BindProperty]
        public Guest Guest { get; set; }

        public RoomBookingPageModel(RoomBookingService roomBookingService)
        {
            _roomBookingService = roomBookingService;
            //roomBookings = _roomBookingService.GetRoomBookings().ToList();
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
            await _roomBookingService.CreateRoomBookingAsync(RoomBooking);
            return RedirectToPage("/OnlineBooking/Thanks");
        }
    }
}
