using System;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Domain.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal Total { get; set; }
        public IEnumerable<ShoppingCartItem> Items { get; internal set; }
    }
}
