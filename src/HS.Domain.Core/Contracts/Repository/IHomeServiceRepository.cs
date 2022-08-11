using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceRepository 
    {
        Task<HomeServiceDto> GetBy(int id, CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> GetAll(CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> GetAll(int subCategoryId, CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> GetAll(Guid id, CancellationToken cancellationToken);
        Task Create(HomeServiceDto entity, CancellationToken cancellationToken);
        Task Update(HomeServiceDto entity, CancellationToken cancellationToken);
        Task Active(int id, CancellationToken cancellationToken);
        Task DeActive(int id, CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> Search(string keyword, CancellationToken cancellationToken);
    }
}
