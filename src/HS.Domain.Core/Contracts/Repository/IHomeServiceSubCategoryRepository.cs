

using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceSubCategoryRepository
    {
        Task<HomeServiceSubCategoryDto> GetBy(int id, CancellationToken cancellationToken);
        Task<HomeServiceSubCategoryDto> GetBy(string name, CancellationToken cancellationToken);
        Task<List<HomeServiceSubCategoryDto>> GetAll(CancellationToken cancellationToken);
        Task Create(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken);
        Task Update(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken);
        Task<List<HomeServiceSubCategoryDto>> GetAllBy(int homeServiceCategoryId, CancellationToken cancellationToken);

    }
}
