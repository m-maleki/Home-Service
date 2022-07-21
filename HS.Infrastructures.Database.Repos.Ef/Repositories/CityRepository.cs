using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly HSDbContext _context;

        public CityRepository(HSDbContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetAll()
        => await _context.Cities.AsNoTracking().ToListAsync();
    }
}
