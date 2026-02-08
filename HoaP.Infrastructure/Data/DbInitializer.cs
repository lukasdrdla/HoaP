using HoaP.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HoaP.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static async Task SeedAdminAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();

            var adminEmail = configuration["AdminSettings:Email"] ?? "admin@admin.com";
            var adminPassword = configuration["AdminSettings:Password"]
                ?? throw new InvalidOperationException(
                    "Admin password not configured. Set AdminSettings:Password in appsettings.json or environment variables.");

            var existingAdmin = await userManager.FindByEmailAsync(adminEmail);
            if (existingAdmin != null) return;

            var admin = new AppUser
            {
                Id = "d4e5f6a7-b8c9-0123-defa-234567890123",
                UserName = adminEmail,
                Email = adminEmail,
                EmailConfirmed = true,
                FirstName = "Admin",
                LastName = "Admin",
                Address = "Hlavní 123",
                City = "Praha",
                PostalCode = "11000",
                Country = "Česká republika",
                PersonalIdentificationNumber = "CZ0000000000",
                PlaceOfBirth = "Praha",
                JobTitle = "Admin",
                StartDate = new DateTime(2025, 1, 1, 12, 0, 0),
                Salary = 50000,
                IsEmployed = true,
                InsuranceCompanyId = 1
            };

            var result = await userManager.CreateAsync(admin, adminPassword);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(admin, "Admin");
            }
        }
    }
}
