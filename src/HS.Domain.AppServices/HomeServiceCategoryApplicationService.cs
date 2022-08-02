using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
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

        public HomeServiceCategoryApplicationService(IHomeServiceCategoryService homeServiceCategoryService)
        {
            _homeServiceCategoryService = homeServiceCategoryService;
        }

        public async Task<List<HomeServiceCategoryDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _homeServiceCategoryService.GetAll(cancellationToken);
        }
    }
}
