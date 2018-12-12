using System;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SignInForm.Models
{
    public class ApplicationContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext() : base("Accounts")
        {

        }

        public static ApplicationContext Create()
        {
            return new ApplicationContext();
        }
    }
}