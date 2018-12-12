using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SignInForm.Models
{
    public class ApplicationUser:IdentityUser
    {

        public int Year { get; set; }
       /* public string Password { get; set; }*/ //after migration
        public ApplicationUser()
        {

        }
    }
}