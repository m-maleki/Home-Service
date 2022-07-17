﻿using AutoMapper;
using HS.Domain.Core.Dtos;
using HS.Domain.Core.Entities;


namespace HS.Infrastructures.Database.Repos.Ef.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
         CreateMap<HomeServiceSubCategory, HomeServiceSubCategoryDto>();
         CreateMap<HomeServiceCategory, HomeServiceCategoryDto>();
         CreateMap<HomeServiceDto, HomeService>();

            CreateMap<HomeService, HomeServiceDto>();
         CreateMap<Suggestion, SuggestionDto>();
         CreateMap<Customer, CustomerDto>();
         CreateMap<Comment, CommentDto>();
         CreateMap<Expert, ExpertDto>();
         CreateMap<ExpertDto, Expert>();
         CreateMap<Image, ImageDto>();
         CreateMap<Order, OrderDto>();

        }
    }
}
