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
    internal class OrderFileConfiguration : IEntityTypeConfiguration<OrderFile>
    {
        public void Configure(EntityTypeBuilder<OrderFile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("OrderFiles");

            builder.HasOne(x => x.Order)
                .WithMany(x => x.OrderFiles);
        }
    }
}
