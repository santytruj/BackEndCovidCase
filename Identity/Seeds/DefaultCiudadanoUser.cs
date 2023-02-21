using Application.Enums;
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Seeds
{
    public static class DefaultCiudadanoUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default Admin User
            var defaultUser = new ApplicationUser
            {
                UserName = "userCiudadano",
                Email = "userCiudadano@mail.com",
                Nombre = "UsuarioCiudadano",
                Apellido = "Ciudadano",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "@Ciudadano12345");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Ciudadado.ToString());

                }
            }
        }
    }
}
