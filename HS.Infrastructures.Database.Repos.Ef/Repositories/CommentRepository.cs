using AutoMapper;
using AutoMapper.QueryableExtensions;
using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using HS.Infrastructures.Database.SqlServer.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public async Task Create(CommentDto entity)
        {
            var record = _mapper.Map<Comment>(entity);
            await _context.Comments.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task<CommentDto> Get(int Id)
        {

            var record = await _mapper.ProjectTo<CommentDto>(_context.Comments).SingleAsync();
            return record;
        }

        public async Task<List<CommentDto>> Get()
        {
            var records = _context.Comments.ToList();
            return _mapper.Map<List<CommentDto>>(records);
        }

        public async Task Update(CommentDto entity)
        {
            var record = await _mapper.ProjectTo<CommentDto>(_context.Set<CommentDto>())
                 .Where(x => x.Id == entity.Id).SingleAsync();
            _mapper.Map(entity, record);
            await _context.SaveChangesAsync();
        }
    }
}
