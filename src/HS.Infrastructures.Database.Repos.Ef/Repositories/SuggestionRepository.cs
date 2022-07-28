using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class SuggestionsRepository :  ISuggestionRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public SuggestionsRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<SuggestionDto>> GetAll()
            => _mapper.Map<List<SuggestionDto>>(await _context.Suggestions
                .AsNoTracking()
                .ToListAsync());
        public async Task<SuggestionDto> GetBy(int id)
            => await _mapper.ProjectTo<SuggestionDto>(_context.Suggestions)
            .AsNoTracking()
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();
        public async Task Update(SuggestionDto entity)
        {
            var record = await _mapper.ProjectTo<SuggestionDto>(_context.Set<SuggestionDto>())
                 .Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
        public async Task Create(SuggestionDto entity)
        {
            var record = _mapper.Map<Suggestion>(entity);
            await _context.Suggestions.AddAsync(record);
            await _context.SaveChangesAsync();
        }
        public async Task<List<SuggestionDto>> GetAll(int orderId)
            =>  _mapper.Map<List<SuggestionDto>>(await _context.Suggestions
                .AsNoTracking()
                .Include(x=>x.Expert)
                .Include(x=>x.Order)
                .ThenInclude(x=>x.HomeService)
                .Include(x=>x.Expert)
                .Where(x=>x.OrderId==orderId)
                .ToListAsync());
        public async Task<int> GetCount(int orderId)
        {
            var record =  await _context.Suggestions
             .AsNoTracking()
             .Where(x => x.OrderId == orderId)
             .ToListAsync();
            return record.Count();
        }
        public async Task<bool> EnsureExistSuggestion(int orderId)
            => await _context.Orders
             .AsNoTracking()
             .Where(x => x.Id == orderId)
             .AnyAsync();
        public async Task Accept(int suggestionId)
        {
            var order = await _context.Suggestions
                .Where(x => x.Id == suggestionId)
                .FirstOrDefaultAsync();
            order.IsAccept = true;
            await _context.SaveChangesAsync();
        }
        public async Task<Guid> GetAcceptSuggestionExpertId(int orderId)
                => await _context.Suggestions
                .AsNoTracking()
                .Where(x=>x.OrderId== orderId && x.IsAccept==true)
                .Select(x=>x.ExpertId)
                .FirstOrDefaultAsync();

        public async Task<int> Count()
        {
            return await _context.Suggestions.AsNoTracking().CountAsync();
        }
    }
}
