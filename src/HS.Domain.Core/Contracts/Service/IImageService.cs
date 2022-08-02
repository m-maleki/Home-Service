using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IImageService
    {
        Task<ImageDto> Get(int Id,CancellationToken cancellationToken);
        Task<List<ImageDto>> GetBy(int orderId, CancellationToken cancellationToken);
        Task Create(ImageDto entity, CancellationToken cancellationToken);
        Task EnsureExists(int Id, CancellationToken cancellationToken);
        Task EnsureDoesNotExist(int Id, CancellationToken cancellationToken);
        Task Update(ImageDto entity, CancellationToken cancellationToken);
    }
}
