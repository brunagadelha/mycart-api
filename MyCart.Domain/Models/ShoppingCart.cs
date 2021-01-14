using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCart.Domain.Models
{
    public class ShoppingCart : Entity
    {
        public ShoppingCart()
        {
            Items = new List<ShoppingCartItem>(); 
        }

        public decimal TotalPrice { get; set; }
        public decimal TotalItems
        {
            get
            {
                return Items.Count();
            }
        }

        public DateTime CreatedAt { get; set; }

        public IEnumerable<ShoppingCartItem> Items { get; internal set; }
        
    }
}
