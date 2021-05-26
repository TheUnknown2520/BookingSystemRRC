using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookingSystemRRC.Pages.Admin
{
    [Authorize(Roles = "Jesper")]
    public class DeleteUserModel : PageModel
    {
        private UserService userService;

        [BindProperty]
        public User User { get; set; }

        public DeleteUserModel(UserService userService)
        {
            this.userService = userService;
        }

        public IActionResult OnGet(int id)
        {
            User = userService.GetUser(id);
            if (User == null)
                return RedirectToPage("/NotFound");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            User = userService.GetUser(id);
            await userService.DeleteUserAsync(User);
            return RedirectToPage("/Admin/ManageUser");
        }
    }
}
