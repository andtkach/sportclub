using Identity.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Identity.Seed
{
    public static class UserCreator
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var applicationUser = new ApplicationUser
            {
                FirstName = "John",
                LastName = "Doe",
                UserName = "johndoe",
                Email = "johndoe@email.com",
                EmailConfirmed = true
            };

            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                await userManager.CreateAsync(applicationUser, "P@ssw0rd");
            }
        }
    }
}