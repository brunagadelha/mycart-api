using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MyCart.Data
{
    public class MyCartContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("connectionStrings.json")
               .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
