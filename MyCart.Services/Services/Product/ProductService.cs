using MyCart.Data.Repositories;
using MyCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCart.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _productRepository;

        public ProductService(IGenericRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(Product product)
        {
            var productExists = _productRepository.GetAll().Where(x => x.Name.Equals(product.Name.Trim())).Any();
            if (productExists)
                return;

            product.CreatedAt = DateTime.Now; 

            _productRepository.Add(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product); 
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll().OrderBy(x => x.Name).ToList();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }
    }
}
