using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSystemRRC.Pages.Admin
{
    [Authorize(Roles = "Jesper")]
    public class ManageUserModel : PageModel
    {
        private UserService userService;
        
        public List<User> users { get; set; }

        [BindProperty]
        public User user { get; set; }


        public ManageUserModel(UserService userService)
        {
            this.userService = userService;

        }

        public IActionResult OnGet()
        {
            users = userService.GetUsers().ToList();
            return Page();
        }
    }
}
