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

        public async Task<List<OrderDto>> GetAllBy(Guid customerId)
        {
            return await _customerService.GetAllBy(customerId);
        }

        public Task<Guid> GetCustomerId(Guid CustomerIdentityId)
            => _customerService.GetCustomerId(CustomerIdentityId);


        public Task Set(CustomerDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task Update(CustomerDto dto)
        {
           // await _customerService.EnsureExists(dto.ApplicationUserId);
            if (dto.ProfileImgFile != null)
                dto.ProfileImgUrl = await _customerService.UploadImageProfile(dto.ProfileImgFile);
            await _customerService.Update(dto);
        }
    }
}
