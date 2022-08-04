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
    public class HomeServiceSubCategoryConfiguration : IEntityTypeConfiguration<HomeServiceSubCategory>
    {
        public void Configure(EntityTypeBuilder<HomeServiceSubCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("HomeServiceSubCategories");

            builder.HasOne(x => x.HomeServiceCategory)
                .WithMany(x => x.HomeServiceSubCategories)
            .OnDelete(DeleteBehavior.Restrict);


            builder.HasMany(x => x.HomeServices)
                .WithOne(x => x.HomeServiceSubCategory)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
               new HomeServiceSubCategory { Id = 1, HomeServiceCategoryId = 1 ,Name = "بنایی" },
               new HomeServiceSubCategory { Id = 2, HomeServiceCategoryId = 1, Name = "دکوراسیون"},
               new HomeServiceSubCategory { Id = 3, HomeServiceCategoryId = 1, Name = "نقاشی ساختمان" },
               new HomeServiceSubCategory { Id = 4, HomeServiceCategoryId = 1, Name = "درب و پنجره" },
               new HomeServiceSubCategory { Id = 5, HomeServiceCategoryId = 1, Name = "آهنگری و جوشکاری" },
               new HomeServiceSubCategory { Id = 6, HomeServiceCategoryId = 1, Name = "باغبانی" },
               new HomeServiceSubCategory { Id = 7 ,HomeServiceCategoryId=  2, Name  = "سرمایش و گرمایش" },
               new HomeServiceSubCategory { Id = 8 ,HomeServiceCategoryId = 2, Name = "لوله کشی" },
               new HomeServiceSubCategory { Id = 9,HomeServiceCategoryId = 2, Name = "برق و الکترونیک" },
               new HomeServiceSubCategory { Id = 10,HomeServiceCategoryId = 2, Name = "تلفن و سانترال" },
               new HomeServiceSubCategory { Id = 11,HomeServiceCategoryId = 3, Name = "خودرو" },
               new HomeServiceSubCategory { Id = 12, HomeServiceCategoryId = 4, Name = "اسباب کشی" },
               new HomeServiceSubCategory { Id = 13, HomeServiceCategoryId = 4, Name = "حمل بار" },
               new HomeServiceSubCategory { Id = 14, HomeServiceCategoryId = 5, Name = "لوازم آشپزخانه" },
               new HomeServiceSubCategory { Id = 15, HomeServiceCategoryId = 5, Name = "لوازم شست و شو و نظافت" },
               new HomeServiceSubCategory { Id = 16, HomeServiceCategoryId = 5, Name = "لوازم صوتی و تصویری" },
               new HomeServiceSubCategory { Id = 17, HomeServiceCategoryId = 6, Name = "ماشین اداری" },
               new HomeServiceSubCategory { Id = 18, HomeServiceCategoryId = 6, Name = "مبلمان اداری" },
               new HomeServiceSubCategory { Id = 19, HomeServiceCategoryId = 7, Name = "نظافت" },
               new HomeServiceSubCategory { Id = 20, HomeServiceCategoryId = 7, Name = "خشکشویی و اتوشویی" },
               new HomeServiceSubCategory { Id = 21, HomeServiceCategoryId = 7, Name = "قالیشویی و مبل شویی" },
               new HomeServiceSubCategory { Id = 22, HomeServiceCategoryId = 7, Name = "سمپاشی" },
               new HomeServiceSubCategory { Id = 23, HomeServiceCategoryId = 8, Name = "موبایل و تبلت" },
               new HomeServiceSubCategory { Id = 24, HomeServiceCategoryId = 8, Name = "خدمات کامپیوتری" },
               new HomeServiceSubCategory { Id = 25, HomeServiceCategoryId = 8, Name = "امنیت و شبکه" },
               new HomeServiceSubCategory { Id = 26, HomeServiceCategoryId = 9, Name = "پزشکی" }
               );
        }
    }
}
