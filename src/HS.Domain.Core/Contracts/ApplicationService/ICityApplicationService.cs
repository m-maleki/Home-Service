using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Contracts.ApplicationService
{
    public interface ICityApplicationService
    {
        Task<List<City>> Get(CancellationToken cancellationToken);
    }
}
