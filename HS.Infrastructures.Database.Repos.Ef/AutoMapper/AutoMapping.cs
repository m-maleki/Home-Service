using AutoMapper;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Infrastructures.Database.Repos.Ef.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
         CreateMap<Comment, CommentDto>();
        }
    }
}
