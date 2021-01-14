using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Data.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products"); 
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100); 
            builder.Property(x => x.Price).IsRequired().HasColumnType("decimal(10, 2)");
        }
    }
}
