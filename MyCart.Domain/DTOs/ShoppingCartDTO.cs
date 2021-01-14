using System;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Domain.DTOs
{
    public class ShoppingCartDTO
    {
        public int Id { get; set; }
        public int TotalPrice { get; set; }
        public int TotalItems { get; set; }
    }
}
