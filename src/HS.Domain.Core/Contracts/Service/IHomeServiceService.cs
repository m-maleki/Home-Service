using HS.Domain.Core.Dtos;
using Microsoft.AspNetCore.Http;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceService
    {
        Task<List<HomeServiceDto>> Get(CancellationToken cancellationToken);
        Task<HomeServiceDto> Get(int id, CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> Get(Guid id, CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> GetAll(int subCategoryId, CancellationToken cancellationToken);
        Task Create(HomeServiceDto homeServiceDto,CancellationToken cancellationToken);
        Task<string> UploadImageProfile(IFormFile FormFile,CancellationToken cancellationToken);
        Task Active(int id, CancellationToken cancellationToken);
        Task DeActive(int id, CancellationToken cancellationToken);
        
    }
}