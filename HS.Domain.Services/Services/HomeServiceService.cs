using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services.Services
{
    public class HomeServiceService : IHomeServiceService
    {
        private readonly IHomeServiceRepository _homeServiceRepository;

        public HomeServiceService(IHomeServiceRepository homeServiceRepository)
        {
            _homeServiceRepository = homeServiceRepository;
        }

        public async Task Create(HomeService entity)
        {
            await _homeServiceRepository.Create(entity);
        }

        public async Task Update(HomeService entity)
        {
            await _homeServiceRepository.Update(entity);
        }

        public async Task<bool> Exists(int Id)
         => await _homeServiceRepository.Exists(x => x.Id == Id);
        public async Task<bool> Exists(string Name)
         => await _homeServiceRepository.Exists(x => x.Name == Name);
        public async Task<HomeService> Get(int Id)
         => await _homeServiceRepository.Get(Id);
        public async Task<List<HomeService>> Get()
         => await _homeServiceRepository.Get();
    }
}
