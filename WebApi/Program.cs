using Application;
using Identity;
using Identity.Contexts;
using Identity.Models;
using Identity.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Persitence;
using Shared;
using WebApi.Extensions;

namespace WebApi
{
    public class Program
    {
        public async static Task Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // Configurar la carga de la configuración de los archivos de configuración
            var configurationBuilder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true)
               .AddEnvironmentVariables();
            var configuration = configurationBuilder.Build();
            builder.Host.ConfigureAppConfiguration((context, configBuilder) =>
            {
                configBuilder.AddConfiguration(configuration);
            });



                // Add services to the container.

                builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
           
            builder.Services.AddAplicationLayer();
            builder.Services.AddIdentityInfraestructure(configuration);
            builder.Services.AddSharedInfraestructure(configuration);
            builder.Services.AddPersistenceInfraestructure(configuration);
            builder.Services.AddApiVersioningExtension();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

      
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                using (var scope = builder.Services.BuildServiceProvider().CreateScope())
                {
                    try
                    {
                        var services = scope.ServiceProvider;
                        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                        await DefaultRoles.SeedAsync(userManager, roleManager);
                        await DefaultAdminUser.SeedAsync(userManager, roleManager);
                        await DefaultBuscadorUser.SeedAsync(userManager, roleManager);
                        await DefaultCiudadanoUser.SeedAsync(userManager, roleManager);
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }

            }

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseErrorHandlerMiddleware();
            app.MapControllers();



            app.Run();

      


        }
    }
}