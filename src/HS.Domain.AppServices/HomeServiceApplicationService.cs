
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

        public async Task Active(int id,CancellationToken cancellationToken)
        {
            await _homeService.Active(id, cancellationToken);
        }

        public async Task Create(HomeServiceDto homeServiceDto, CancellationToken cancellationToken)
        {
            homeServiceDto.ImgSrc =await _homeService.UploadImageProfile(homeServiceDto.ImgFile, cancellationToken);
            await _homeService.Create(homeServiceDto, cancellationToken);
            
        }

        public async Task DeActive(int id, CancellationToken cancellationToken)
        {
            await _homeService.DeActive(id, cancellationToken);
        }

        public async Task<List<HomeServiceDto>> Get(CancellationToken cancellationToken)
        {
            var result = await _homeService.Get(cancellationToken);
            return result;
        }

        public async Task<HomeServiceDto> Get(int id, CancellationToken cancellationToken)
           => await _homeService.Get(id, cancellationToken);

        public async Task<List<HomeServiceDto>> GetAll(int subCategoryId, CancellationToken cancellationToken)
            => await _homeService.GetAll(subCategoryId, cancellationToken);

        public Task<List<HomeServiceDto>> Search(string keyword, CancellationToken cancellationToken)
            => _homeService.Search(keyword, cancellationToken);
    }
}
