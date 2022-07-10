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
        public async Task<Image> Get(int Id)
         => await _imageRepository.Get(Id);
        public async Task<List<Image>> Get()
         => await _imageRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _imageRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"Image with id : {Id} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _imageRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a Image with id = {Id}");
        }
    }
}