using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace HS.Domain.Services
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public ExpertService(IExpertRepository expertRepository,
            UserManager<ApplicationUser> userManager)
        {
            _expertRepository = expertRepository;
            _userManager = userManager;
        }

        public async Task Create(ExpertDto entity)
        {
            await _expertRepository.Create(entity);
        }

        public async Task EnsureDoesNotExist(Guid id)
        {
            if (await _expertRepository.GetBy(id) != null)
                throw new Exception($"Expert Id : {id} Exists!");
        }

        public async Task EnsureExists(Guid id)
        {
            if( await _expertRepository.GetBy(id) == null)
                throw new Exception($"Expert Id : {id} Doesn't Exists!");
        }

        public async Task<ExpertDto> Get(Guid id)
            =>await _expertRepository.GetBy(id);



        public async Task<List<ExpertDto>> Get()
            =>await _expertRepository.GetAll();

        public async Task Update(ExpertDto entity)
        {
           await _expertRepository.Update(entity);
        }

        public async Task<ExpertDto> Get(string email)
        {
            var user =await _userManager.Users.SingleAsync(x => x.Email == email);
            return await _expertRepository.GetBy(user!.Id); 
        }
    }
}
