

using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceSubCategoryRepository
    {
        Task<HomeServiceSubCategoryDto> GetBy(int id);
        Task<HomeServiceSubCategoryDto> GetBy(string name);
        Task<List<HomeServiceSubCategoryDto>> GetAll();
        Task Create(HomeServiceSubCategoryDto entity);
        Task Update(HomeServiceSubCategoryDto entity);
        Task<List<HomeServiceSubCategoryDto>> GetAllBy(int homeServiceCategoryId);

    }
}
