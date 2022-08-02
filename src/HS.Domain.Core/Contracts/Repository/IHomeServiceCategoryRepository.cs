using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceCategoryRepository 
    {
        Task<HomeServiceCategoryDto> GetBy(int id, CancellationToken cancellationToken);
        Task<HomeServiceCategoryDto> GetBy(string name, CancellationToken cancellationToken);
        Task<List<HomeServiceCategoryDto>> GetAll(CancellationToken cancellationToken);
        Task Create(HomeServiceCategoryDto entity, CancellationToken cancellationToken);
        Task Update(HomeServiceCategoryDto entity, CancellationToken cancellationToken);
        
    }
}
