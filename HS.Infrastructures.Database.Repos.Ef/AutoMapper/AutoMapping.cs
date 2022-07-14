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
         CreateMap<HomeServiceCategory, HomeServiceCategoryDto>();
         CreateMap<SpecialtyCategory, SpecialtyCategoryDto>();
         CreateMap<HomeService, HomeServiceDto>();
         CreateMap<Suggestion, SuggestionDto>();
         CreateMap<Specialty, SpecialtyDto>();
         CreateMap<Customer, CustomerDto>();
         CreateMap<Comment, CommentDto>();
         CreateMap<Expert, ExpertDto>();
         CreateMap<Image, ImageDto>();
         CreateMap<Order, OrderDto>();
        }
    }
}
