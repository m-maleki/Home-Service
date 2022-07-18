using AutoMapper;
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
    public class CustomerApplicationService : ICustomerApplicationService
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerApplicationService(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDto> Get(Guid id)
            =>_customerService.Get(id);

        public Task<CustomerDto> Get(string email)
            => _customerService.Get(email);

        public Task<List<CustomerDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Set(CustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public Task Update(CustomerDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
