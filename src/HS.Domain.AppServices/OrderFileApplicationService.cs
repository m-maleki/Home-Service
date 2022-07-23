﻿using HS.Domain.Core.Contracts.ApplicationService;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.ApplicationServices
{
    public class OrderFileApplicationService : IOrderFileApplicationService
    {
        private readonly IOrderFileService _orderFileService;

        public OrderFileApplicationService(IOrderFileService orderFileService)
        {
            _orderFileService = orderFileService;
        }

        public async Task DeleteFile(int fileId)
        {
            var fileName = await _orderFileService.Get(fileId);
            await _orderFileService.DeleteFromHardDisk(fileName.Name);
            await _orderFileService.DeleteFile(fileId);
        }

        public async Task<List<OrderFileDto>> GetAll(int orderId)
        {
            return await _orderFileService.GetAll(orderId);
        }
    }
}