using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class SuggestionRepository :  ISuggestionRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public SuggestionRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<SuggestionDto>> GetAll()
            => _mapper.Map<List<SuggestionDto>>(await _context.Suggestions.ToListAsync());

        public async Task<SuggestionDto> GetBy(int id)
            => await _mapper.ProjectTo<SuggestionDto>(_context.Suggestions).Where(x => x.Id == id).SingleOrDefaultAsync();

        public async Task Create(SuggestionDto entity)
        {
            var record = _mapper.Map<Suggestion>(entity);
            await _context.Suggestions.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task Update(SuggestionDto entity)
        {
            var record = await _mapper.ProjectTo<SuggestionDto>(_context.Set<SuggestionDto>())
                 .Where(x => x.Id == entity.Id).SingleOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
    }
}
