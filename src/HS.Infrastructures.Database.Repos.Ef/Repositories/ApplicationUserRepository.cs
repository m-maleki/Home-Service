using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> Create(ApplicationUserDto command)
        {
            var user = new ApplicationUser();
            if (command.Role=="Customer")
            {
                 user = new ApplicationUser
                {
                    UserName = command.Email,
                    Email = command.Email,
                    Customer = new Customer()
                };
            }

            if (command.Role == "Expert")
            {
                user = new ApplicationUser
                {
                    UserName = command.Email,
                    Email = command.Email,
                    Expert = new Expert()
                };
            }

            var result = await _userManager.CreateAsync(user, command.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, command.Role);
            }
            return result;
        }

        public async Task<List<ApplicationUserDto>> GetAll()
        {
           var users = _mapper.Map<List<ApplicationUserDto>>(await _userManager.Users
              .AsNoTracking()
              .ToListAsync());

            foreach (var item in users)
            {
               var userRole  = await _userManager.GetRolesAsync(await _userManager.Users.FirstAsync(x => x.Id == item.Id));
               item.Role = userRole.First();
            }
            return users;
        }

        public async Task<SignInResult> Login(ApplicationUserDto command)
           =>  await _signInManager.PasswordSignInAsync(command.Email, command.Password, true, false);
    }
}
