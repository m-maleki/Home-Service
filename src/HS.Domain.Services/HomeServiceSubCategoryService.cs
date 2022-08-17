using HS.Domain.ApplicationServices;
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
    public class HomeServiceSubCategoryService : IHomeServiceSubCategoryService
    {
        private readonly IHomeServiceSubCategoryRepository _homeServiceSubCategoryRepository;

        public HomeServiceSubCategoryService(IHomeServiceSubCategoryRepository homeServiceSubCategoryRepository)
        {
            _homeServiceSubCategoryRepository = homeServiceSubCategoryRepository;
        }

        public Task Create(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<HomeServiceSubCategoryDto>> GetAll(CancellationToken cancellationToken)
            => await _homeServiceSubCategoryRepository.GetAll(cancellationToken);

        public async Task<List<HomeServiceSubCategoryDto>> GetAllBy(int homeServiceCategoryId, CancellationToken cancellationToken)
            => await (_homeServiceSubCategoryRepository.GetAllBy(homeServiceCategoryId, cancellationToken));

        public Task<HomeServiceSubCategoryDto> GetBy(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HomeServiceSubCategoryDto> GetBy(string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(HomeServiceSubCategoryDto entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
