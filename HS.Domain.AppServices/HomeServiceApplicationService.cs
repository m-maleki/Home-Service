
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

        public Task<List<HomeServiceDto>> Get()
            => _homeService.Get();
    }
}
