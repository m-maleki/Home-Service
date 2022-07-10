using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IImageService
    {
        Task<Image> Get(int Id);
        Task<List<Image>> Get();
        Task Create(Image entity);
        Task<bool> Exists(int Id);
        Task<bool> Exists(string Name);
        Task Update(Image entity);
    }
}
