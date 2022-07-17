using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface IHomeServiceApplicationService
    {
        Task<List<HomeServiceDto>> Get();
        Task<HomeServiceDto> Get(int id);
    }
}
