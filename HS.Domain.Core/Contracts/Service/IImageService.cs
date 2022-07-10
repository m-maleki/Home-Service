using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IImageService
    {
        Task<Image> Get(int Id);
        Task<List<Image>> Get();
        Task Create(Image entity);
        Task EnsureExists(int Id);
        Task EnsureDoesNotExist(int Id);
        Task Update(Image entity);
    }
}
