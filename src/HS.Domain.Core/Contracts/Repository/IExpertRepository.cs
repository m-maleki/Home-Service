using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IExpertRepository 
    {
        Task<ExpertDto> GetBy(Guid id, CancellationToken cancellationToken);
        Task<List<ExpertDto>> GetAll(CancellationToken cancellationToken);
        Task Create(ExpertDto entity, CancellationToken cancellationToken);
        Task Update(ExpertDto entity, CancellationToken cancellationToken);
        Task<Guid> GetExpertId(Guid expertIdentityId, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetAllBy(Guid expertId, CancellationToken cancellationToken);
        Task<List<ExpertDto>> GetAll(Guid id, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);


    }
}
