using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Entities;


namespace HS.Domain.Services.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public async Task Create(Image entity)
        {
            await _imageRepository.Create(entity);
        }

        public async Task Update(Image entity)
        {
            await _imageRepository.Update(entity);
        }

        public async Task<bool> Exists(int Id)
         => await _imageRepository.Exists(x => x.Id == Id);
        public async Task<bool> Exists(string Name)
         => await _imageRepository.Exists(x => x.Name == Name);
        public async Task<Image> Get(int Id)
         => await _imageRepository.Get(Id);
        public async Task<List<Image>> Get()
         => await _imageRepository.Get();
    }
}
