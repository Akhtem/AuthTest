using System;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Owin;
using SignInForm.Models;


[assembly: OwinStartup(typeof(SignInForm.App_Start.Startup))]
namespace SignInForm.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // настраиваем контекст и менеджер
            app.CreatePerOwinContext<ApplicationContext>(ApplicationContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
            app.UseCookieAuthentication(new Microsoft.Owin.Security.Cookies.CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }
    }
}

/*<connectionStrings>
  <add name="Accounts" providerName="System.Data.SqlClient" connectionString="Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Accounts.mdf;Integrated Security=True;" />
</connectionStrings>
*/