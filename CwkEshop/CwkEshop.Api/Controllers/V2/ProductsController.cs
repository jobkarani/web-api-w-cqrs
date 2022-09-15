using CwkEshop.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CwkEshop.Api.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route ([{id}])]

        public IActionResult GetById(int id){
            var product = new Product(Id = id, Name = "Rider");
            return Ok(product);
        }
    }
}
