
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

        public async Task<List<HomeServiceDto>> Get()
            =>await _homeService.Get();

        public async Task<HomeServiceDto> Get(int id)
           => await _homeService.Get(id);

    }
}
