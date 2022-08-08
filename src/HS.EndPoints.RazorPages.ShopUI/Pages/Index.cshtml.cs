using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Domain.Services;
using HS.Infrastructures.Database.Repos.Ef.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.Text;

namespace HS.EndPoints.RazorPages.ShopUI.Pages
{

    public class IndexModel : PageModel
    {

        private readonly IHomeServiceCategoryApplicationService _homeServiceCategoryApplicationService;
        private readonly IDistributedCache _cache;
        private readonly IMemoryCache _memoryCache;
        private readonly ISmsService _smsService;

        public IndexModel(IHomeServiceCategoryApplicationService homeServiceCategoryApplicationService,
            IDistributedCache cache,
            IMemoryCache memoryCache,
            ISmsService smsService)
        {
            _homeServiceCategoryApplicationService = homeServiceCategoryApplicationService;
            _cache = cache;
            _memoryCache = memoryCache;
            _smsService = smsService;
        }

        public List<HomeServiceCategoryDto> homeServiceCategories;


        public async Task OnGet(CancellationToken cancellationToken)
        {
                homeServiceCategories = await _homeServiceCategoryApplicationService.GetAll(cancellationToken);
        }
    }
}
