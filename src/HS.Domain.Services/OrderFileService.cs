﻿using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class OrderFileService : IOrderFileService
    {
        private readonly IOrderFileRepository _orderFileRepository;

        public OrderFileService(IOrderFileRepository orderFileRepository)
        {
            _orderFileRepository = orderFileRepository;
        }

        public async Task DeleteFile(int fileId, CancellationToken cancellationToken)
        {
            await _orderFileRepository.DeleteFile(fileId, cancellationToken);
        }

        public async Task DeleteFromHardDisk(string fileName)
        {
            // delet file from hard disk ...
        }

        public async Task<OrderFileDto> Get(int fileId, CancellationToken cancellationToken)
            => await _orderFileRepository.Get(fileId, cancellationToken);

        public async Task<List<OrderFileDto>> GetAll(int orderId, CancellationToken cancellationToken)
            => await _orderFileRepository.GetAll(orderId, cancellationToken);
    }
}
