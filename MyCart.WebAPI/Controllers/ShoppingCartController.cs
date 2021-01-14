using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyCart.Services.Services;

namespace MyCart.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IMapper _mapper;

        public ShoppingCartController(IMapper mapper, IShoppingCartService shoppingCartService)
        {
            _mapper = mapper;
            _shoppingCartService = shoppingCartService;
        }

        [HttpPost]
        public void Post()
        {
        }

        // PUT api/<ShoppingCartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShoppingCartController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
