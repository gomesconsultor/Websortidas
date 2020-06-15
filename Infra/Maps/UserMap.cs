using ApiSortidas.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSortidas.Infra.Maps
{
    public class UserMap: IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(user => user.Id);
            builder.Property(x => x.CreateDate).IsRequired();
            builder.Property(x => x.LastUpdate).IsRequired();
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.Password).IsRequired()
                .HasMaxLength(12);
            builder.Property(x => x.Usuario)
             .IsRequired()
             .HasMaxLength(30)
             .HasColumnType("varchar(30)");
            builder.Property(x => x.Email)
             .IsRequired()
             .HasMaxLength(255)
             .HasColumnType("varchar(255)");
        }
    }
}
