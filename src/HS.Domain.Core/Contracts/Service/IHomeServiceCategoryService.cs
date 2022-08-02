using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;


namespace HS.Domain.Core.Contracts.Service
{
    public interface IHomeServiceCategoryService
    {
        Task<List<HomeServiceCategoryDto>> GetAll(CancellationToken cancellationToken);

    }
}
