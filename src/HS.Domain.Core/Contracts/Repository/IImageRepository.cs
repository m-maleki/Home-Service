using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IImageRepository 
    {
        Task<List<ImageDto>> GetBy(int orderId);
        Task Create(ImageDto entity);
        Task Update(ImageDto entity);
    }
}
