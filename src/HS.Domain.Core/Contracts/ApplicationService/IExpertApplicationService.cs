using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface IExpertApplicationService
    {
        Task<List<ExpertDto>> GetAll(CancellationToken cancellationToken);
        Task Set(ExpertDto dto, CancellationToken cancellationToken);
        Task<ExpertDto> Get(CancellationToken cancellationToken);
        Task<ExpertDto> Get(string email, CancellationToken cancellationToken);
        Task Update(ExpertDto dto, CancellationToken cancellationToken);
        Task<Guid> GetExpertId(CancellationToken cancellationToken);
        Task Delete(Guid id, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetAllBy(Guid expertId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}