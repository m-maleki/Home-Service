using HS.Domain.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface IHomeServiceCategoryApplicationService
    {
        Task<List<HomeServiceCategoryDto>> GetAll(CancellationToken cancellationToken);
    }
}
