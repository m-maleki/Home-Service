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
    public class OrderApplicationService : IOrderApplicationService
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;

        public OrderApplicationService(IOrderService orderService,
            ICustomerService customerService)
        {
            _orderService = orderService;
            _customerService = customerService;
        }

        public Task Create(OrderDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDto> Get(int Id)
         => await  _orderService.Get(Id);

        public async Task<List<OrderDto>> Get()
         => await _orderService.Get();

        public async Task<List<OrderDto>> GetAllBy(Guid customerId)
        {
            var applicatioUserId = await _customerService.GetGuid(customerId);
             return await _orderService.GetAllBy(applicatioUserId);
        }



        public Task Update(OrderDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
