using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookingSystemRRC.Services;
using BookingSystemRRC.Models;

namespace BookingSystemRRC.Pages.BookingRRC
{
    public class GetAllOrdersModel : PageModel
    {
        private BookingService bookingService;

        public Guest Guest { get; set; }

        public GetAllOrdersModel(BookingService bookingService)
        {
            this.bookingService = bookingService;
        }
        //public async Task OnGetAcync(int Id)
        //{
        //    Guest = await bookingService

        //}
    }
}
