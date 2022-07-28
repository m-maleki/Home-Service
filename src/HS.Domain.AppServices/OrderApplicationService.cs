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
        private readonly IApplicationUserService _applicationUserService;
        public OrderApplicationService(IOrderService orderService,
            ICustomerService customerService,
            IExpertService expertService,
            IApplicationUserService applicationUserService)
        {
            _orderService = orderService;
            _customerService = customerService;
            _expertService = expertService;
            _applicationUserService = applicationUserService;
        }

        public async Task<int> Count()
        {
            return await _orderService.Count();
        }

        public async Task Create(OrderDto entity, List<IFormFile> FormFile)
        {
            entity.CustomerId= await _customerService.GetCustomerId(_applicationUserService.GetUserId());
            PersianCalendar pc = new PersianCalendar();
            TimeSpan time = new TimeSpan(int.Parse(entity.Clock.Substring(0,2)), int.Parse(entity.Clock.Substring(3, 2)),0);
            entity.DateOfExecution = new DateTime(entity.DateOfExecution.Year, entity.DateOfExecution.Month, entity.DateOfExecution.Day,  pc);
            entity.DateOfExecution =  entity.DateOfExecution.Add(time);
            entity.currentApplicationUserID = _applicationUserService.GetUserId().ToString();
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

        public async Task<List<OrderDto>> GetAll()
        {
             var role = await _applicationUserService.getRole();

            if (role=="Expert")
            {
                var expertCustomerid = await _expertService.GetExpertId(_applicationUserService.GetUserId());
                return await _expertService.GetAllBy(expertCustomerid);
            }
            else if(role == "Customer")
            {
                var customerid = await _customerService.GetCustomerId(_applicationUserService.GetUserId());
                return await _customerService.GetAllBy(customerid);
            }
            else if (role == "Admin")
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
