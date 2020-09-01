using System;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Domain.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
