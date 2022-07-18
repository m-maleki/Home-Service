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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task Create(OrderDto entity)
        {
           await _orderRepository.Create(entity);
        }

        public Task EnsureDoesNotExist(int Id)
        {
            throw new NotImplementedException();
        }

        public Task EnsureExists(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderDto> Get(int Id)
          => await _orderRepository.GetBy(Id);

        public async Task<List<OrderDto>> Get()
           => await _orderRepository.GetAll();

        public async Task<List<OrderDto>> GetAllBy(Guid customerId)
           => await _orderRepository.GetAllBy(customerId);

        public Task Update(OrderDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
