using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Service
{
    public interface IOrderFileService
    {
        Task<List<OrderFileDto>> GetAll(int orderId);
        Task DeleteFile(int fileId);
        Task DeleteFromHardDisk(string fileName);
        Task<OrderFileDto> Get(int fileId);
    }
}
