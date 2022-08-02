using AutoMapper;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;

namespace HS.Infrastructures.Database.Repos.Ef.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly IMapper _mapper;
        private readonly HSDbContext _context;

        public CommentRepository(HSDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<CommentDto>> GetBy(Guid expertId, CancellationToken cancellationToken)
            => await _mapper.ProjectTo<CommentDto>(_context.Comments
                .AsNoTracking()
                .Include(x => x.Expert))
                .Where(x => x.ExpertId == expertId && x.IsAccept == true)
                .ToListAsync(cancellationToken);
        public async Task Create(string comment, Guid expertId, CancellationToken cancellationToken)
        {
            Comment record = new Comment()
            {
                Body = comment,
                ExpertId = expertId
            };
            await _context.Comments.AddAsync(record);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task<List<CommentDto>> GetAll(CancellationToken cancellationToken)
            => _mapper.Map<List<CommentDto>>(await _context.Comments
                .AsNoTracking()
                .Include(x => x.Expert)
                .ToListAsync(cancellationToken));
        public async Task<CommentDto> GetBy(int id, CancellationToken cancellationToken)
            => await _mapper.ProjectTo<CommentDto>(_context.Comments)
            .AsNoTracking()
            .Where(x=>x.Id==id)
            .FirstOrDefaultAsync(cancellationToken);
        public async Task Update(CommentDto entity, CancellationToken cancellationToken)
        {
            
            var record = await _mapper.ProjectTo<CommentDto>(_context.Set<CommentDto>())
                 .Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task DeActive(int commentId, CancellationToken cancellationToken)
        {
            var order = await _context.Comments
            .Where(x => x.Id == commentId)
            .SingleAsync(cancellationToken);
            order.IsAccept = false;
            await _context.SaveChangesAsync();
        }
        public async Task Active(int commentId, CancellationToken cancellationToken)
        {
            var order = await _context.Comments
            .Where(x => x.Id == commentId)
            .FirstOrDefaultAsync();
            order.IsAccept = true;
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}