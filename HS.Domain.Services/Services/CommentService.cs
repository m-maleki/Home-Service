﻿using HS.Domain.Core.Contracts.Repository;
using HS.Domain.Core.Contracts.Service;
using HS.Domain.Core.Entities;

namespace HS.Domain.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public async Task Create(Comment entity)
        {
            await _commentRepository.Create(entity);
        }
        public async Task Update(Comment entity)
        {
            await _commentRepository.Update(entity);
        }
        public async Task<Comment> Get(int Id)
         => await _commentRepository.Get(Id);
        public async Task<List<Comment>> Get()
         => await _commentRepository.Get();
        public async Task EnsureDoesNotExist(int Id)
        {
            if (await _commentRepository.Exists(x => x.Id == Id) == true)
                throw new Exception($"there is already a Comment with id = {Id}");
        }
        public async Task EnsureExists(int Id)
        {
            if (await _commentRepository.Exists(x => x.Id == Id) == false)
                throw new Exception($"Comment with id : {Id} Not Exist !");
        }
    }
}