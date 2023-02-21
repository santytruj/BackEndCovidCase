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
    public static class DefaultAdminUser
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Default Admin User
            try
            {
                var defaultUser = new ApplicationUser
                {
                    UserName = "userAdmin",
                    Email = "userAdmin@mail.com",
                    Nombre = "UsuarioAdmin",
                    Apellido = "Admin",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };

                if (userManager.Users.All(u => u.Id != defaultUser.Id))
                {
                    var user = await userManager.FindByEmailAsync(defaultUser.Email);
                    if (user == null)
                    {
                        await userManager.CreateAsync(defaultUser, "@Admin12345");
                        await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                        await userManager.AddToRoleAsync(defaultUser, Roles.Buscador.ToString());
                        await userManager.AddToRoleAsync(defaultUser, Roles.Ciudadado.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
