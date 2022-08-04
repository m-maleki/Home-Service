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
                .WithOne(x => x.HomeServiceCategory)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new HomeServiceCategory { Id = 1, Name = "دکوراسیون ساختمان" , ImgSrc= "7c6466ad-8fe0-4b81-812f-cfb72620a681.svg" },
                new HomeServiceCategory { Id = 2, Name = "تاسیسات ساختمان" , ImgSrc= "e39bce31-df3c-4db0-859e-5bb5f344741e.svg" },
                new HomeServiceCategory { Id = 3, Name = "وسایل نقلیه" ,ImgSrc= "8cd28fef-f5bb-4d95-9ac5-1ed35d23d99b.svg" },
                new HomeServiceCategory { Id = 4, Name = "اسباب کشی و باربری",ImgSrc= "da7a1e99-d360-4b44-a851-f80d3d24489c.svg" },
                new HomeServiceCategory { Id = 5, Name = "لوازم خانگی" ,ImgSrc= "15d5e842-6ac9-4c75-98ab-204497289fac.svg" },
                new HomeServiceCategory { Id = 6, Name = "خدمات اداری" ,ImgSrc= "5754a1ce-665c-4fa9-b8ae-206650960c1a.svg" },
                new HomeServiceCategory { Id = 7, Name = "نظافت و بهداشت" ,ImgSrc= "7cb97fcc-d549-4421-9a81-b4f97498121c.svg" },
                new HomeServiceCategory { Id = 8, Name = "دیجیتال و نرم افزار" ,ImgSrc= "3219d232-b9e0-4581-bac5-b5a13c1e2664.svg" },
                new HomeServiceCategory { Id = 9, Name = "پزشکی و سلامت" ,ImgSrc= "59e143b3-669e-431a-9a3a-306457529e4c.svg" }
                );
        }
    }
}
