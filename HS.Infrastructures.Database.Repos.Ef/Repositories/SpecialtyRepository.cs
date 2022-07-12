using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class SpecialtyRepository : ISpecialtyRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public SpecialtyRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SpecialtyDto>> GetAll()
            => _mapper.Map<List<SpecialtyDto>>(await _context.Specialties.ToListAsync());

        public async Task<SpecialtyDto> GetBy(int id)
            => await _mapper.ProjectTo<SpecialtyDto>(_context.Comments).Where(x => x.Id == id).SingleOrDefaultAsync();

        public async Task Create(SpecialtyDto entity)
        {
            var record = _mapper.Map<Specialty>(entity);
            await _context.Specialties.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Update(SpecialtyDto entity)
        {
            var record = await _mapper.ProjectTo<SpecialtyDto>(_context.Set<SpecialtyDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
    }
}
