using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IImageRepository 
    {
        Task<List<ImageDto>> GetBy(int orderId, CancellationToken cancellationToken);
        Task Create(ImageDto entity, CancellationToken cancellationToken);
        Task Update(ImageDto entity, CancellationToken cancellationToken);
    }
}
