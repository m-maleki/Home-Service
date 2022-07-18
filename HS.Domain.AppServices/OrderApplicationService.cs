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

        public OrderApplicationService(IOrderService orderService)
        {
            _orderService = orderService;
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
         => await _orderService.GetAllBy(customerId);

        public Task Update(OrderDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
