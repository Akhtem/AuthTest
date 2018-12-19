using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SignInForm.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Country { get; set; }
        public string Password { get; set; }
        public int Year { get; set; }

        public ApplicationUser()
        {

        }
    }
}