
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;

namespace HS.Domain.ApplicationServices
{
    public class HomeServiceApplicationService : IHomeServiceApplicationService
    {
        private readonly IHomeServiceService _homeService;

        public HomeServiceApplicationService(IHomeServiceService homeService)
        {
            _homeService = homeService;
        }

        public async Task Active(int id)
        {
            await _homeService.Active(id);
        }

        public async Task Create(HomeServiceDto homeServiceDto)
        {
            homeServiceDto.ImgSrc =await _homeService.UploadImageProfile(homeServiceDto.ImgFile);
            await _homeService.Create(homeServiceDto);
            
        }

        public async Task DeActive(int id)
        {
            await _homeService.DeActive(id);
        }

        public async Task<List<HomeServiceDto>> Get()
        {
            var result = await _homeService.Get();
            return result;
        }

        public async Task<HomeServiceDto> Get(int id)
           => await _homeService.Get(id);

        public async Task<List<HomeServiceDto>> GetAll(int subCategoryId)
        {
            return await _homeService.GetAll(subCategoryId);
        }
    }
}
