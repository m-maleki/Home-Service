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

        public async Task Create(OrderDto entity)
        {
            entity.CustomerId= await _customerService.GetGuid(new Guid(entity.currentApplicationUserID));
            string clock = entity.Clock;
            TimeSpan time = new TimeSpan(int.Parse(clock.Substring(0,2)), int.Parse(clock.Substring(3, 2)),0);

            await _orderService.Create(entity);
        }

        public async Task<OrderDto> Get(int Id)
         => await  _orderService.Get(Id);

        public async Task<List<OrderDto>> Get()
         => await _orderService.Get();

        public async Task<List<OrderDto>> GetAllBy(Guid customerId)
        {
            var id = await _customerService.GetGuid(customerId);
             return await _orderService.GetAllBy(id);
        }



        public Task Update(OrderDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
