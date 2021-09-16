using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bitmoonfasttrade.Models;
using Bitmoonfasttrade.Enums;

public static class ContextSeed
{
    public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        //Seed Roles
        await roleManager.CreateAsync(new IdentityRole(Bitmoonfasttrade.Enums.Roles.SuperAdmin.ToString()));
        await roleManager.CreateAsync(new IdentityRole(Bitmoonfasttrade.Enums.Roles.Basic.ToString()));
    }
    public static async Task SeedSuperAdminAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
{
    //Seed Default User
    var defaultUser = new ApplicationUser 
    { 
        UserName = "superadmin", 
        Email = "abumchicaleb@gmail.com",
        FirstName = "Joe",
        LastName = "Chi",
        EmailConfirmed = true, 
        PhoneNumberConfirmed = true 
    };
    if (userManager.Users.All(u => u.Id != defaultUser.Id))
    {
        var user = await userManager.FindByEmailAsync(defaultUser.Email);
        if(user==null)
        {
            await userManager.CreateAsync(defaultUser, "123Pa$$word.");
            await userManager.AddToRoleAsync(defaultUser, Bitmoonfasttrade.Enums.Roles.Basic.ToString());
            await userManager.AddToRoleAsync(defaultUser, Bitmoonfasttrade.Enums.Roles.SuperAdmin.ToString());
        }
               
    }
}
}