using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ApiSortidas.Domain.Entities;
using System;

namespace ApiSortidas.Infra.Maps
{
    public class IngridientsMap : IEntityTypeConfiguration<Ingridients>
    {
        public void Configure(EntityTypeBuilder<Ingridients> builder)
        {
            builder.ToTable("Ingridienty");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.LastUpdate).IsRequired();
            builder.Property(x => x.Price).IsRequired().HasColumnType("money");
            builder.Property(x => x.Unity).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.Description)
             .IsRequired()
             .HasMaxLength(1024)
             .HasColumnType("varchar(1024)");
            builder.Property(x => x.Title)
             .IsRequired()
             .HasMaxLength(120)
             .HasColumnType("varchar(120)");
        }
    }
}
