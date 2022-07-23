using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class OrderApplicationService : IOrderApplicationService
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IExpertService _expertService;

        public OrderApplicationService(IOrderService orderService,
            ICustomerService customerService,
            IExpertService expertService)
        {
            _orderService = orderService;
            _customerService = customerService;
            _expertService = expertService;
        }

        public async Task Create(OrderDto entity, List<IFormFile> FormFile)
        {
            entity.CustomerId= await _customerService.GetCustomerId(new Guid(entity.currentApplicationUserID));
            PersianCalendar pc = new PersianCalendar();
            TimeSpan time = new TimeSpan(int.Parse(entity.Clock.Substring(0,2)), int.Parse(entity.Clock.Substring(3, 2)),0);
            entity.DateOfExecution = new DateTime(entity.DateOfExecution.Year, entity.DateOfExecution.Month, entity.DateOfExecution.Day,  pc);
            entity.DateOfExecution =  entity.DateOfExecution.Add(time);
            var orderId = await _orderService.Create(entity);
            if(FormFile !=null)
            {
            var files = await _orderService.UploadFiles(FormFile, orderId);
            await _orderService.SetOrderFiles(files, orderId);
            }
        }

        public async Task<OrderDto> Get(int Id)
         => await  _orderService.Get(Id);

        public async Task<List<OrderDto>> Get()
         => await _orderService.Get();

        public async Task<List<OrderDto>> GetAllBy(Guid Id, IList<string> roles)
        {
            if(roles.Any(x => x.Contains("Expert")))
            {
                var expertCustomerid = await _expertService.GetExpertId(Id);
                return await _expertService.GetAllBy(expertCustomerid);
            }
            else if(roles.Any(x => x.Contains("Customer")))
            {
                var customerid = await _customerService.GetCustomerId(Id);
                return await _customerService.GetAllBy(customerid);
            }
            else if (roles.Any(x => x.Contains("Admin")))
            {
                return await _orderService.Get();
            }
            return default;
        }

        public async Task<OrderDto> GetBy(int orderId)
        {
           return await _orderService.GetBy(orderId);
        }

        public async Task<OrderStatusEnum> GetOrderStatusEnum(int orderId)
        {
            return await _orderService.GetOrderStatusEnum(orderId);
        }

        public async Task HardDelete(int orderId)
        {
            await _orderService.HardDelete(orderId);
        }

        public async Task SetOrderStatusEnum(int orderId, OrderStatusEnum orderStatusEnum)
        {
            await _orderService.SetOrderStatusEnum(orderId, orderStatusEnum);
        }

        public async Task SoftDelete(int orderId)
        {
            await _orderService.SoftDelete(orderId);
        }

        public async Task SoftRecover(int orderId)
        {
            await _orderService.SoftRecover(orderId);
        }

        public Task Update(OrderDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
