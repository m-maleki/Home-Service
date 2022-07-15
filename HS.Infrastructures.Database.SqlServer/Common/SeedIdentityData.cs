using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace HS.Infrastructures.Database.SqlServer.Common
{
    public class SeedIdentityData
    {

        private  readonly UserManager<ApplicationUser> _userManager;
        private  readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public  SeedIdentityData(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole<Guid>> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Inistialize()
        {
            if (_userManager.Users.Count() == 0)
            {
                var user = new ApplicationUser
                {
                    Email = "maleki.jm@gmail.com",
                    NormalizedEmail = "MALEKI.JM@GMAIL.COM",
                    UserName = "maleki.jm@gmail.com",
                    NormalizedUserName = "ADMINISTRATOR",
                    PhoneNumber = "+989377507920",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                await _roleManager.CreateAsync(new IdentityRole<Guid>("Admin"));
                await _roleManager.CreateAsync(new IdentityRole<Guid>("Customer"));
                await _roleManager.CreateAsync(new IdentityRole<Guid>("Expert"));
                await _userManager.CreateAsync(user, "25915491");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
