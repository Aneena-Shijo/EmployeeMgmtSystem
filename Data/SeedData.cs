using EmployeeMgmtSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

public class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        var roleNames = new[] { "Admin", "User" };

        // Check if roles exist, and create them if they don't
        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        // Create a default Admin user if not exists
        var adminUser = await userManager.FindByEmailAsync("admin@example.com");
        if (adminUser == null)
        {
            adminUser = new ApplicationUser { UserName = "admin@example.com", Email = "admin@example.com" };
            await userManager.CreateAsync(adminUser, "Admin@123");
        }

        // Assign the Admin role to the user
        if (!await userManager.IsInRoleAsync(adminUser, "Admin"))
        {
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }

        // Create a default User user if not exists
        var regularUser = await userManager.FindByEmailAsync("user@example.com");
        if (regularUser == null)
        {
            regularUser = new ApplicationUser { UserName = "user@example.com", Email = "user@example.com" };
            await userManager.CreateAsync(regularUser, "User@123");
        }

        // Assign the User role to the user
        if (!await userManager.IsInRoleAsync(regularUser, "User"))
        {
            await userManager.AddToRoleAsync(regularUser, "User");
        }
    }
}

