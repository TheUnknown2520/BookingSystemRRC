using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class CreateGuestModel : PageModel
    {
        private GuestService guestService { get; set; }

        private List<Models.Guest> guests { get; set; }

        [BindProperty]
        public Models.Guest Guest { get; set; }

        public CreateGuestModel(GuestService guestService)
        {
            this.guestService = guestService;

            guests = guestService.GetGuests().ToList();
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> onPost()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await guestService.CreateGuestAsync(Guest);
            return RedirectToPage("/BookingRRC/BookingAcceptance");
        }
    }
}
