using HS.Domain.Core.Dtos;
using Microsoft.AspNetCore.Http;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceService
    {
        Task<List<HomeServiceDto>> Get();
        Task<HomeServiceDto> Get(int id);
        Task<List<HomeServiceDto>> Get(Guid id);
        Task<List<HomeServiceDto>> GetAll(int subCategoryId);
        Task Create(HomeServiceDto homeServiceDto);
        Task<string> UploadImageProfile(IFormFile FormFile);
        Task Active(int id);
        Task DeActive(int id);
    }
}