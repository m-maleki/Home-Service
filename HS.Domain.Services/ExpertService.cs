using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace HS.Domain.Services
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHomeServiceRepository _homeServiceRepository;
        private readonly IMapper _mapper;


        public ExpertService(IExpertRepository expertRepository,
            UserManager<ApplicationUser> userManager,
            IHomeServiceRepository homeServiceRepository,
            IMapper mapper)
        {
            _expertRepository = expertRepository;
            _userManager = userManager;
            _homeServiceRepository = homeServiceRepository;
            _mapper = mapper;
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
            if (await _expertRepository.GetBy(id) == null)
                throw new Exception($"Expert Id : {id} Doesn't Exists!");
        }

        public async Task<ExpertDto> Get(Guid id)
            => await _expertRepository.GetBy(id);

        public async Task<List<ExpertDto>> Get()
            => await _expertRepository.GetAll();

        public async Task Update(ExpertDto entity)
        {
            await _expertRepository.Update(entity);
        }

        public async Task<ExpertDto> Get(string email)
        {
            var user = await _userManager.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Email == email);
            return await _expertRepository.GetBy(user!.Id);
        }

        public async Task<string> UploadImageProfile(IFormFile FormFile)
        {
            string filePath;
            string fileName;
            if (FormFile != null)
            {
                fileName = Guid.NewGuid().ToString() +
                ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');
                filePath = Path.Combine("wwwroot/Images/Profiles", fileName);
                try
                {
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await FormFile.CopyToAsync(stream);
                    }
                }
                catch
                {
                    throw new Exception("Upload files operation failed");
                }
                return fileName;
            }
            else
                fileName = "";
            return fileName;
        }

        public async Task<ExpertDto> AssignHomeService(ExpertDto entity)
        {
            foreach (var homeServiceId in entity.HomeServicesIds)
            {
                var record = await _homeServiceRepository.GetBy(homeServiceId);
                var homeService = new HomeService();

                _mapper.Map(record, homeService);
                entity.HomeServices.Add(homeService);
            }
            return entity;
        }
    }
}
