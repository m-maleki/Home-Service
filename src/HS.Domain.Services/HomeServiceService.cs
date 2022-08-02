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

        public async Task Active(int id, CancellationToken cancellationToken)
        {
           await _homeServiceRepository.Active(id, cancellationToken);
        }

        public async Task Create(HomeServiceDto homeServiceDto, CancellationToken cancellationToken)
        {
          await _homeServiceRepository.Create(homeServiceDto, cancellationToken);
        }

        public async Task DeActive(int id, CancellationToken cancellationToken)
        {
            await _homeServiceRepository.DeActive(id, cancellationToken);
        }

        public async Task<HomeServiceDto> Get(int id, CancellationToken cancellationToken)
            => await _homeServiceRepository.GetBy(id, cancellationToken);
        public async Task<List<HomeServiceDto>> Get(CancellationToken cancellationToken)
         => await  _homeServiceRepository.GetAll(cancellationToken);

        public async Task<List<HomeServiceDto>> Get(Guid id, CancellationToken cancellationToken)
        {

            return await _homeServiceRepository.GetAll(id, cancellationToken);
        }

        public async Task<List<HomeServiceDto>> GetAll(int subCategoryId, CancellationToken cancellationToken)
        {
           return await _homeServiceRepository.GetAll(subCategoryId, cancellationToken);
        }

        public async Task<string> UploadImageProfile(IFormFile FormFile, CancellationToken cancellationToken)
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
