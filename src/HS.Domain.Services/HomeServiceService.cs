using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class HomeServiceService : IHomeServiceService
    {
        private readonly IHomeServiceRepository _homeServiceRepository;

        public HomeServiceService(IHomeServiceRepository homeServiceRepository)
        {
            _homeServiceRepository = homeServiceRepository;
        }

        public async Task Active(int id)
        {
           await _homeServiceRepository.Active(id);
        }

        public async Task Create(HomeServiceDto homeServiceDto)
        {
          await _homeServiceRepository.Create(homeServiceDto);
        }

        public async Task DeActive(int id)
        {
            await _homeServiceRepository.DeActive(id);
        }

        public async Task<HomeServiceDto> Get(int id)
            => await _homeServiceRepository.GetBy(id);
        public async Task<List<HomeServiceDto>> Get()
         => await  _homeServiceRepository.GetAll();

        public async Task<List<HomeServiceDto>> Get(Guid id)
        {

            return await _homeServiceRepository.GetAll(id);
        }

        public async Task<List<HomeServiceDto>> GetAll(int subCategoryId)
        {
           return await _homeServiceRepository.GetAll(subCategoryId);
        }

        public async Task<string> UploadImageProfile(IFormFile FormFile)
        {
            string filePath;
            string fileName;
            if (FormFile != null)
            {
                fileName = Guid.NewGuid().ToString() +
                ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');
                filePath = Path.Combine("wwwroot/Images/HomeService", fileName);
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
    }
}
