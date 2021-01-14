using MyCart.Data.Repositories;
using MyCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Services.Services
{
    class ShoppingCartService : IShoppingCartService
    {
        private readonly IGenericRepository<ShoppingCart> _shoppingCartRepository; 

        public ShoppingCartService(IGenericRepository<ShoppingCart> shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository; 
        } 

        public void Add()
        {
            var shoppingCart = new ShoppingCart
            {
                CreatedAt = DateTime.Now
            };

            _shoppingCartRepository.Add(shoppingCart); 
        }
    }
}
