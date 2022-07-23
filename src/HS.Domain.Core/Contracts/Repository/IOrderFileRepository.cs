using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface IOrderFileRepository
    {
        Task<List<OrderFileDto>> GetAll(int orderId);
        Task<OrderFileDto> Get(int fileId);
        Task DeleteFile(int fileId);
    }
}
