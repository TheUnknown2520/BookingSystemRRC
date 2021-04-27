using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Pages.BookingFolder
{
    public class ConferenceRoomModel : PageModel
    {
        public Guest Guest {get; set; }

        public void OnGet()
        {
        }
    }
}
