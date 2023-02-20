using Microsoft.AspNetCore.Identity;
using TeaShop.Models;

namespace TeaShop.Data
{
    //public class DataSeeder 
    //{
    //    private const string adminUser = "Admin";
    //    private const string adminPassword = "Qwerty1234";
    //    private const string adminEmail = "admin@gmail.com";
    //    public static async void EnsurePopulated(IApplicationBuilder app)
    //    {
    //        using (var scope = app.ApplicationServices.CreateScope())
    //        {
    //            var userManager = (UserManager<AppUser>)scope
    //                                .ServiceProvider.GetService(typeof(UserManager<IdentityUser>));
    //            IdentityUser user = await userManager.FindByIdAsync(adminUser);
    //            if (user == null)
    //            {
    //                var admin = new IdentityUser
    //                {
    //                    UserName = "admin@gmail.com",
    //                    Email = "admin@gmail.com",
    //                    EmailConfirmed = true
    //                };
    //                user = new IdentityUser(adminUser);
    //                await userManager.CreateAsync(user, adminPassword);
    //            }
    //        }
    //    }
    //}
}