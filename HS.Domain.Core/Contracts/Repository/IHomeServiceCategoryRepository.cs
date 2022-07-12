using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IHomeServiceCategoryRepository 
    {
        Task<HomeServiceCategoryDto> GetBy(int id);
        Task<HomeServiceCategoryDto> GetBy(string name);
        Task<List<HomeServiceCategoryDto>> GetAll();
        Task Create(HomeServiceCategoryDto entity);
        Task Update(HomeServiceCategoryDto entity);
    }
}
