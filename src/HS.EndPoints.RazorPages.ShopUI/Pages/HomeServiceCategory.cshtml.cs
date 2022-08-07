using AutoMapper;
using HS.Domain.Core.Contracts.ApplicationService;
using HS.EndPoints.RazorPages.UI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;

namespace HS.EndPoints.RazorPages.UI.Pages
{
    public class HomeServiceCategoryModel : PageModel
    {
        private readonly IHomeServiceSubCategoryApplicationService _homeServiceSubCategoryApplicationService;
        public List<HomeServiceSubCategoryViewModel> homeServiceSubCategory;
        private readonly IMapper _mapper;
        private readonly IDistributedCache _cache;


        public HomeServiceCategoryModel(IHomeServiceSubCategoryApplicationService homeServiceSubCategoryApplicationService,
            IMapper mapper,
            IDistributedCache cache)
        {
            _homeServiceSubCategoryApplicationService = homeServiceSubCategoryApplicationService;
            _mapper = mapper;
            _cache = cache;
        }

        public async Task OnGet(int id,CancellationToken cancellationToken)
        {
            homeServiceSubCategory = _mapper.Map(await _homeServiceSubCategoryApplicationService.GetAllBy(id, cancellationToken),
                new List<HomeServiceSubCategoryViewModel>());
        }

        //public async Task OnGet(int id, CancellationToken cancellationToken)
        //{
        //    try
        //    {
        //        var cachedItem = await _cache.GetStringAsync("homeServiceSubCategory");
        //        var result = JsonConvert.DeserializeObject<List<HomeServiceSubCategoryViewModel>>(cachedItem);
        //        homeServiceSubCategory = _mapper.Map(result, new List<HomeServiceSubCategoryViewModel>());
        //    }
        //    catch (ArgumentNullException)
        //    {
        //        homeServiceSubCategory = _mapper.Map(await _homeServiceSubCategoryApplicationService.GetAllBy(id, cancellationToken),
        //        new List<HomeServiceSubCategoryViewModel>());
        //        var jsonString = JsonConvert.SerializeObject(homeServiceSubCategory);
        //        await _cache.SetStringAsync("homeServiceSubCategory", jsonString);
        //    }
        //}
    }
}
