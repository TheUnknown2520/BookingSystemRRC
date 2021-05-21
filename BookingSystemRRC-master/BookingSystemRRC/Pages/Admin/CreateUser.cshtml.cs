using System;
using System.Collections.Generic;
using BookingSystemRRC.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSystemRRC.Pages.Admin
{
    public class CreateUserModel : PageModel
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        
        public void OnGet()
        {
        }
    }
}
