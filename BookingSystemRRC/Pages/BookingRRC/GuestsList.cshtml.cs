using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class GuestsListModel : PageModel
    {
        private GuestService guestService;

        public List<Models.Guest> guests { get; private set; }


        [BindProperty]
        public string Search { get; set; }

        public GuestsListModel(GuestService guestService)
        {
            this.guestService = guestService;
            
        }
        public IActionResult OnGet()
        {
            guests = guestService.GetGuests().ToList();
            return Page();
        }

        public IActionResult OnPostNameSearch()
        {
            guests = guestService.NameSearch(Search).ToList();
            return Page();
        }
    }
}
