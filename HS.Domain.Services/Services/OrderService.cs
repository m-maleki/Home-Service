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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task Create(Order entity)
        {
            await _orderRepository.Create(entity);
        }
        public async Task Update(Order entity)
        {
            await _orderRepository.Update(entity);
        }
        public async Task<Order> Get(int Id)
         => await _orderRepository.Get(Id);
        public async Task<List<Order>> Get()
         => await _orderRepository.Get();
        public async Task EnsureExists(int Id)
        {
            if (await _orderRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"Order with id : {Id} Not Exist !");
        }
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _orderRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a Order with id = {Id}");
        }
    }
}