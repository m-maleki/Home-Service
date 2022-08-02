using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IExpertService
    {
        Task<ExpertDto> Get(Guid id, CancellationToken cancellationToken);
        Task<ExpertDto> Get(string email, CancellationToken cancellationToken);
        Task<List<ExpertDto>> Get(CancellationToken cancellationToken);
        Task Create(ExpertDto entity, CancellationToken cancellationToken);
        Task Update(ExpertDto entity, CancellationToken cancellationToken);
        Task EnsureExists(Guid id, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(Guid id, CancellationToken cancellationToken);
        Task<Guid> GetExpertId(Guid expertIdentityId, CancellationToken cancellationToken);
        Task<string> UploadImageProfile(IFormFile FormFile, CancellationToken cancellationToken);
        Task<ExpertDto> AssignHomeService(ExpertDto entity, CancellationToken cancellationToken);
        Task<List<OrderDto>> GetAllBy(Guid expertId, CancellationToken cancellationToken);
        Task<int> Count(CancellationToken cancellationToken);
    }
}