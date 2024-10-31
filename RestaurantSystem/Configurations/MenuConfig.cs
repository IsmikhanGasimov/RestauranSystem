using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Configurations
{
    internal class MenuConfig : IEntityTypeConfiguration<Entities.Menu>
    {
        public void Configure(EntityTypeBuilder<Entities.Menu> builder)
        {
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Description)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(x => x.Price)
                   .HasColumnType("decimal(18, 2)")
                   .IsRequired();
        }
    }
}
