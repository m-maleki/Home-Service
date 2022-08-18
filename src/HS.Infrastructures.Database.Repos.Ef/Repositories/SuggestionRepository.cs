using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class SuggestionsRepository :  ISuggestionRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;
        private readonly ILogger<SuggestionsRepository> _loger;

        public SuggestionsRepository(HSDbContext context,
            IMapper mapper,
            ILogger<SuggestionsRepository> loger)
        {
            _context = context;
            _mapper = mapper;
            _loger = loger;
        }
        public async Task<List<SuggestionDto>> GetAll(CancellationToken cancellationToken)
            => _mapper.Map<List<SuggestionDto>>(await _context.Suggestions
                .AsNoTracking()
                .Include(x=>x.Expert)
                .Include(x=>x.Order)
                .ThenInclude(x=>x.HomeService)
                .ToListAsync(cancellationToken));

        public async Task<SuggestionDto> GetBy(int id, CancellationToken cancellationToken)
            => await _mapper.ProjectTo<SuggestionDto>(_context.Suggestions
            .AsNoTracking()
            .Include(x=>x.Expert)
            .ThenInclude(x=>x.ApplicationUser))
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);

        public async Task Update(SuggestionDto entity, CancellationToken cancellationToken)
        {
            var record = await _mapper.ProjectTo<SuggestionDto>(_context.Set<SuggestionDto>())
                 .Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Create(SuggestionDto entity, CancellationToken cancellationToken)
        {
            var record = _mapper.Map<Suggestion>(entity);
            try
            {
                await _context.Suggestions.AddAsync(record);
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch(Exception ex)
            {
                _loger.LogError("Error in add new Suggestion {exception}", ex);
            }
        }

        public async Task<List<SuggestionDto>> GetAll(int orderId, CancellationToken cancellationToken)
            =>  _mapper.Map<List<SuggestionDto>>(await _context.Suggestions
                .AsNoTracking()
                .Include(x=>x.Expert)
                .Include(x=>x.Order)
                .ThenInclude(x=>x.HomeService)
                .Include(x=>x.Expert)
                .Where(x=>x.OrderId==orderId)
                .ToListAsync(cancellationToken));

        public async Task<int> GetCount(int orderId, CancellationToken cancellationToken)
        {
            var record =  await _context.Suggestions
             .AsNoTracking()
             .Where(x => x.OrderId == orderId)
             .ToListAsync(cancellationToken);
            return record.Count();
        }

        public async Task<bool> EnsureExistSuggestion(int orderId, CancellationToken cancellationToken)
            => await _context.Orders
             .AsNoTracking()
             .Where(x => x.Id == orderId)
             .AnyAsync(cancellationToken);

        public async Task Accept(int suggestionId,CancellationToken cancellationToken)
        {
            var order = await _context.Suggestions
                .Where(x => x.Id == suggestionId)
                .FirstOrDefaultAsync();
            order.IsAccept = true;
            try
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
            catch(Exception ex)
            {
                _loger.LogError("Error in Accept Suggestion {exception}", ex);
            }
        }

        public async Task<Guid> GetAcceptSuggestionExpertId(int orderId, CancellationToken cancellationToken)
                => await _context.Suggestions
                .AsNoTracking()
                .Where(x=>x.OrderId== orderId && x.IsAccept==true)
                .Select(x=>x.ExpertId)
                .FirstOrDefaultAsync(cancellationToken);

        public async Task<int> Count(CancellationToken cancellationToken)
        {
            return await _context.Suggestions.AsNoTracking().CountAsync(cancellationToken);
        }
    }
}
