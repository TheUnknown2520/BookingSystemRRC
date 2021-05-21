using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BookingSystemRRC.Models;
using BookingSystemRRC.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace BookingSystemRRC.Pages.LogInSystem
{
    public class LogInModel : PageModel
    {
        //public static User LoggedInUser { get; set; } = null;
        private UserService _userService;

        public LogInModel(UserService userService )
        {
            _userService = userService;
        }

        [BindProperty]
        public string Username { get; set; }
        [BindProperty, DataType(DataType.Password)] 
        public string Password { get; set; }

        public string Message { get; set; }
        
        public async Task<IActionResult> OnPost()
        {
            List<User> users = _userService.users;
            foreach (User user in users)
            {
                if (Username == user.Username)
                {

                    var passwordHasher = new PasswordHasher<string>();
                    if (passwordHasher.VerifyHashedPassword(null, user.Password, Password) == PasswordVerificationResult.Success)
                    { 
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, Username)
                        };

                        if (Username == "Jesper") claims.Add(new Claim(ClaimTypes.Role, "Jesper"));
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                    return RedirectToPage("/InternallySystem/EmployeeCalendar");

                    }
                }
            }
            Message = "Forkert brugernavn eller adgangskode";
            return Page();
        }
    }
}
