using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSystemRRC.Pages.Admin
{
    public class CreateUserModel : PageModel
    {
        private UserService _userService;

        private PasswordHasher<string> passwordHasher;

        
        [BindProperty]
        public string Username { get; set; }
        [BindProperty, DataType(DataType.Password)]
        public string Password { get; set; }


        public CreateUserModel(UserService userService)
        {
            _userService = userService;
            passwordHasher = new PasswordHasher<string>();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userService.AddUser(new User(Username, passwordHasher.HashPassword(null, Password)));
            return RedirectToPage("/Admin/ManageUser");
        }
    }
}
