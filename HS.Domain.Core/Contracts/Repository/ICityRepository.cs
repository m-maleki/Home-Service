
using HS.Domain.Core.Entities;

namespace HS.Domain.Core.Contracts.Repository
{
    public interface ICityRepository
    {
        Task<List<City>> GetAll();
    }
}
