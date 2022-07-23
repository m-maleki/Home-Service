using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IImageService
    {
        Task<ImageDto> Get(int Id);
        Task<List<ImageDto>> GetBy(int orderId);
        Task Create(ImageDto entity);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);
        Task Update(ImageDto entity);
    }
}
