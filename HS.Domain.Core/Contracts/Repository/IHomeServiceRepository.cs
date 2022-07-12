using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceRepository 
    {
        Task<HomeServiceDto> GetBy(int id);
        Task<List<HomeServiceDto>> GetAll();
        Task Create(HomeServiceDto entity);
        Task Update(HomeServiceDto entity);
    }
}
