using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void OnGet()
        {
        }
    }
}
