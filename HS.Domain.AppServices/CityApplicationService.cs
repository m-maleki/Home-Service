
using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Entities;

namespace HS.Domain.ApplicationServices
{
    public class CityApplicationService : ICityApplicationService
    {
        private readonly ICityService _cityService;

        public CityApplicationService(ICityService cityService)
        {
            _cityService = cityService;
        }

        public async Task<List<City>> Get()
         =>  await _cityService.Get();
    }
}
