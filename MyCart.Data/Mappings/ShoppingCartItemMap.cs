using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Data.Mappings
{
    class ShoppingCartItemMap : IEntityTypeConfiguration<ShoppingCartItem>
    {
        public void Configure(EntityTypeBuilder<ShoppingCartItem> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();

            builder.HasOne(x => x.Product)
                        .WithMany()
                        .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.ShoppingCart)
                        .WithMany(x => x.Items)
                        .HasForeignKey(x => x.ShoppingCartId); 

        }
    }
}
