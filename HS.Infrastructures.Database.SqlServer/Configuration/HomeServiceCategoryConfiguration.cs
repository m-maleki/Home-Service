using HS.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Infrastructures.Database.SqlServer.Configuration
{
    public class HomeServiceCategoryConfiguration : IEntityTypeConfiguration<HomeServiceCategory>
    {
        public void Configure(EntityTypeBuilder<HomeServiceCategory> builder)
        {
            builder.ToTable("HomeServiceCategories");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.HomeServiceSubCategories)
                .WithOne(x => x.HomeServiceCategory);

            builder.HasData(
                new HomeServiceCategory { Id = 1, Name = "دکوراسیون ساختمان" },
                new HomeServiceCategory { Id = 2, Name = "تاسیسات ساختمان" },
                new HomeServiceCategory { Id = 3, Name = "وسایل نقلیه" },
                new HomeServiceCategory { Id = 4, Name = "اسباب کشی و باربری" },
                new HomeServiceCategory { Id = 5, Name = "لوازم خانگی" },
                new HomeServiceCategory { Id = 6, Name = "خدمات اداری" },
                new HomeServiceCategory { Id = 7, Name = "نظافت و بهداشت" },
                new HomeServiceCategory { Id = 8, Name = "دیجیتال و نرم افزار" },
                new HomeServiceCategory { Id = 9, Name = "پزشکی و سلامت" }
                );
        }
    }
}
