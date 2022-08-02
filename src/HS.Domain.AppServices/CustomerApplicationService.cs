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
        private readonly IApplicationUserApplicationService _userApplicationService;
        private readonly ICityService _cityService;


        public CustomerApplicationService(ICustomerService customerService,
            IMapper mapper,
            IApplicationUserApplicationService userApplicationService,
            ICityService cityService)
        {
            _customerService = customerService;
            _mapper = mapper;
            _userApplicationService = userApplicationService;
            _cityService = cityService;
        }

        public async Task<int> Count(CancellationToken cancellationToken)
        {
            return await _customerService.Count(cancellationToken);
        }

        public Task Delete(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerDto> Get(CancellationToken cancellationToken)
        {
            var customer =await _customerService.GetCustomerId(_userApplicationService.GetUserId(cancellationToken), cancellationToken);
            var result =  await _customerService.Get(customer, cancellationToken);
            result.Cities =await _cityService.Get(cancellationToken);
            return result;
        }
          

        public Task<CustomerDto> Get(string email, CancellationToken cancellationToken)
            => _customerService.Get(email, cancellationToken);
        
        public Task<List<CustomerDto>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OrderDto>> GetAllBy(Guid customerId, CancellationToken cancellationToken)
        {
            return await _customerService.GetAllBy(customerId, cancellationToken);
        }

        public Task<Guid> GetCustomerId(Guid CustomerIdentityId, CancellationToken cancellationToken)
            => _customerService.GetCustomerId(CustomerIdentityId, cancellationToken);


        public Task Set(CustomerDto dto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task Update(CustomerDto dto, CancellationToken cancellationToken)
        {
           // await _customerService.EnsureExists(dto.ApplicationUserId);
            if (dto.ProfileImgFile != null)
                dto.ProfileImgUrl = await _customerService.UploadImageProfile(dto.ProfileImgFile, cancellationToken);
            await _customerService.Update(dto, cancellationToken);
        }
    }
}
