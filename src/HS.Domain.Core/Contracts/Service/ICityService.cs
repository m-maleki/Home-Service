using HS.Domain.Core.Entities;


namespace HS.Domain.Core.Contracts.Service
{
    public interface ICityService
    {
        Task<List<City>> Get(CancellationToken cancellationToken);
    }
}
