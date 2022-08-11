using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos.ApplicationUsers;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
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
        private readonly HSDbContext _dbContext;
        public ApplicationUserRepository(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IMapper mapper,
            HSDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _dbContext = dbContext;
        }



        public async Task<bool> confirmEmail(string token)
        {
            var record = await _dbContext.Users
                .Where(x => x.ConfirmationToken == token)
                .FirstOrDefaultAsync();

            if(record != null)
            {
                record.EmailConfirmed = true;
                record.ConfirmationToken = "";
                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> IsExist(string emailAddress)
        {
            var record = await _dbContext.Users
                .Where(x => x.NormalizedEmail == emailAddress.ToUpper())
                .FirstOrDefaultAsync();

            if (record is not null) return true;
            else return false;

        }

        public async Task<IdentityResult> Create(ApplicationUserDto command, CancellationToken cancellationToken)
        {
            var user = new ApplicationUser();
            if (command.Role=="Customer")
            {
                user = new ApplicationUser
                {
                    ConfirmationToken = "",
                    UserName = command.Email,
                    Email = command.Email,
                    Customer = new Customer()
                };
            }

            if (command.Role == "Expert")
            {
                user = new ApplicationUser
                {
                    ConfirmationToken = "",
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
        public async Task ActiveEmailConfirm(string emailAddress)
        {
            var record = await _dbContext.Users
              .Where(x => x.Email == emailAddress)
             .FirstOrDefaultAsync();
            record.EmailConfirmed = true;
            await _dbContext.SaveChangesAsync();
        }
        public async Task<bool> EmailIsConfirmed(string emailAddress)
        {
            return await _dbContext.Users
             .AsNoTracking()
             .Where(x => x.Email == emailAddress)
             .Select(x=>x.IsConfirmed)
             .FirstOrDefaultAsync();
        }

        public async Task DeActiveEmailConfirm(string emailAddress)
        {
            var record = await _dbContext.Users
              .Where(x => x.Email == emailAddress)
             .FirstOrDefaultAsync();
            record.EmailConfirmed = false;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<ApplicationUserDto>> GetAll(CancellationToken cancellationToken)
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

        public async Task<SignInResult> Login(ApplicationUserDto command, CancellationToken cancellationToken)
           =>  await _signInManager.PasswordSignInAsync(command.Email, command.Password, true, false);

        public async Task SetConfirmKey(string emailAddress,Guid confirmKey)
        {
            var record = await _dbContext.Users
                  .Where(x=>x.Email==emailAddress)
                 .FirstOrDefaultAsync();
            record.ConfirmationToken = confirmKey.ToString();
            await _dbContext.SaveChangesAsync();
        }
    }
}
