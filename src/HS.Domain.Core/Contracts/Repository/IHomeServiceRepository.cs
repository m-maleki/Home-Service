using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceRepository 
    {
        Task<HomeServiceDto> GetBy(int id);
        Task<List<HomeServiceDto>> GetAll();
        Task<List<HomeServiceDto>> GetAll(int subCategoryId);
        Task<List<HomeServiceDto>> GetAll(Guid id);
        Task Create(HomeServiceDto entity);
        Task Update(HomeServiceDto entity);
        Task Active(int id);
        Task DeActive(int id);
    }
}
