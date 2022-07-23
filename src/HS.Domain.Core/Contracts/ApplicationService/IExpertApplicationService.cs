using HS.Domain.Core.Dtos;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface IExpertApplicationService
    {
        Task<List<ExpertDto>> GetAll();
        Task Set(ExpertDto dto);
        Task<ExpertDto> Get(Guid id);
        Task<ExpertDto> Get(string email);
        Task Update(ExpertDto dto);
        Task<Guid> GetExpertId(Guid expertIdentityId);
        Task Delete(Guid id);
        Task<List<OrderDto>> GetAllBy(Guid expertId);
    }
}