using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCart.Domain.Models;
using MyCart.Services.Services;
using MyCart.WebAPI.DTOs;

namespace MyCart.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper; 
            _productService = productService; 
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProductDTO> Get(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
                return NotFound("Produto não encontrado");

            return _mapper.Map<ProductDTO>(product); 
        }

        [HttpGet]
        [Route("All")]
        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _productService.GetAll().ToList();
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO dto)
        {
            var product = _mapper.Map<Product>(dto);  
            _productService.Add(product);
            return NoContent(); 
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Put(int id, [FromBody] ProductDTO dto)
        {
            var product = _productService.GetById(id);
            if (product == null)
                return NotFound();

            product.Name = dto.Name;
            product.Price = dto.Price;

            _productService.Update(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
                return NotFound("Produto não encontrado");

            _productService.Delete(product);

            return NoContent(); 
        }
    }
}
