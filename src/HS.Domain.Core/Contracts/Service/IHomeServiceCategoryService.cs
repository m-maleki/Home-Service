using HS.Domain.Core.Entities;


namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceCategoryService
    {
        Task<HomeServiceCategory> Get(int Id);
        Task<List<HomeServiceCategory>> Get();
        Task Create(HomeServiceCategory entity);
        Task EnsureExists(int Id);
        Task EnsureExists(string Name);
        Task EnsureDoesNotExist(int Id);
        Task EnsureDoesNotExist(string Name);
        Task Update(HomeServiceCategory entity);
    }
}
