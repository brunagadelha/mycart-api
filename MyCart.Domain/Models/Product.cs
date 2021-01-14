using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyCart.Domain.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
