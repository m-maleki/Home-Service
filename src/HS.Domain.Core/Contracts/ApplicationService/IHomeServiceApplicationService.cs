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
        Task<List<HomeServiceDto>> Get(CancellationToken cancellationToken);
        Task<HomeServiceDto> Get(int id, CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> GetAll(int subCategoryId, CancellationToken cancellationToken);
        Task Create(HomeServiceDto homeServiceDto, CancellationToken cancellationToken);
        Task Active(int id, CancellationToken cancellationToken);
        Task DeActive(int id, CancellationToken cancellationToken);
        Task<List<HomeServiceDto>> Search(string keyword, CancellationToken cancellationToken);
    }
}
