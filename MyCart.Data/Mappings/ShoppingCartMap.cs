using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Data.Mappings
{
    public class ShoppingCartMap : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TotalPrice).IsRequired(); //set precision => money 
            builder.Property(x => x.CreatedAt).IsRequired(); 
        }
    }
}
