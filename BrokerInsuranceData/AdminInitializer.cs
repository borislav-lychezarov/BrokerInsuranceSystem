using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace BrokerInsuranceData
{
    public class AdminInitializer
    {
        public static async Task Initializer(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var roleName = "Admin";
            IdentityResult identityResult;

            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                identityResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                if (identityResult.Succeeded)
                {
                    var admin = await userManager
                        .FindByEmailAsync("boss@mail.com");
                    if (admin == null)
                    {
                        admin = new IdentityUser
                        {
                            Email = "boss@mail.com",
                            UserName = "boss@mail.com",
                            EmailConfirmed = true
                        };

                        identityResult = await userManager
                            .CreateAsync(admin, "1stronGPasswordToday!");
                        if (identityResult.Succeeded)
                        {
                            await userManager.AddToRoleAsync(admin, roleName);
                        }
                    }
                }
            }
        }
    }
}
