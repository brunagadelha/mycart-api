using MyCart.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyCart.Services.Services
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int id);
        IEnumerable<Product> GetAll();
    }
}
