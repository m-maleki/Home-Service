using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository _imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        public Task Create(ImageDto entity)
        {
            throw new NotImplementedException();
        }

        public Task EnsureDoesNotExist(int Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ImageDto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImageDto>> GetBy(int orderId)
        {
            return _imageRepository.GetBy(orderId);
        }

        public Task Update(ImageDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
