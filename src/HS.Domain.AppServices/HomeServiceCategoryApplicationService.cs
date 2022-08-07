using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class HomeServiceCategoryApplicationService : IHomeServiceCategoryApplicationService
    {
        private readonly IHomeServiceCategoryService _homeServiceCategoryService;
        private readonly IMemoryCache _memoryCache;

        public HomeServiceCategoryApplicationService(IHomeServiceCategoryService homeServiceCategoryService,
            IMemoryCache memoryCache)
        {
            _homeServiceCategoryService = homeServiceCategoryService;
            _memoryCache = memoryCache;
        }

        public async Task<List<HomeServiceCategoryDto>> GetAll(CancellationToken cancellationToken)
        {
            if (_memoryCache.Get<List<HomeServiceCategoryDto>>("homeServiceCategories") != null)
            {
                return _memoryCache.Get<List<HomeServiceCategoryDto>>("homeServiceCategories");
            }
            else
            {
                var result = await _homeServiceCategoryService.GetAll(cancellationToken);
                _memoryCache.Set("homeServiceCategories", result, DateTimeOffset.Now.AddSeconds(30));
                return result;
            }
        }
    }
}
