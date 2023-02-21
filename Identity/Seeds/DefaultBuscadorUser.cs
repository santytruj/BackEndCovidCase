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
    public static class DefaultBuscadorUser
    {

        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default Admin User
            var defaultUser = new ApplicationUser
            {
                UserName = "userBuscador",
                Email = "userBuscador@mail.com",
                Nombre = "UsuarioBuscador",
                Apellido = "Buscador",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "@Buscador12345");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Buscador.ToString());

                }
            }
        }
    }
}
