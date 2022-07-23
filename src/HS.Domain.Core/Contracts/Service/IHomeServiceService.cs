using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceService
    {
        Task<List<HomeServiceDto>> Get();
        Task<HomeServiceDto> Get(int id);
        Task<List<HomeServiceDto>> Get(Guid id);
        Task<List<HomeServiceDto>> GetAll(int subCategoryId);
    }
}