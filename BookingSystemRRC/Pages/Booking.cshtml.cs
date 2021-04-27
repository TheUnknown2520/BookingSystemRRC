using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookingSystemRRC.Pages
{
    public class BookingModel : PageModel
    {
        private readonly ILogger<BookingModel> _logger;

        public BookingModel(ILogger<BookingModel> logger)
        {
            _logger = logger;
        }

        public Guest Guest { get; set; }

        public void OnGet()
        {
            Guest = new Guest() { BookingId = 1, Name = "Christopher", Address = "Østerdalsgade 12", Email = "Chrisseria2520@gmail.com", PhoneNumber = 31353551, Comment = "Der skal stå øl klar" };
        }
    }
}
