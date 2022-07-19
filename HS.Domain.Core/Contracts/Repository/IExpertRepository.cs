using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IExpertRepository 
    {
        Task<ExpertDto> GetBy(Guid id);
        Task<List<ExpertDto>> GetAll();
        Task Create(ExpertDto entity);
        Task Update(ExpertDto entity);
        Task<Guid> GetExpertId(Guid expertIdentityId);
        Task<List<OrderDto>> GetAllBy(Guid expertId);
        Task<List<ExpertDto>> GetAll(Guid id);
    }
}
