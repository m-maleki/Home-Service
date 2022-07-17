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
    public class HomeServiceService : IHomeServiceService
    {
        private readonly IHomeServiceRepository _homeServiceRepository;

        public HomeServiceService(IHomeServiceRepository homeServiceRepository)
        {
            _homeServiceRepository = homeServiceRepository;
        }

        public async Task<List<HomeServiceDto>> Get()
         => await  _homeServiceRepository.GetAll();

    }
}
