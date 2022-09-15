using CwkEshop.Api.Services;
using CwkEshop.Dal;
using CwkEshop.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CwkEshop.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route ([{id}])]

        public IActionResult GetById(int id){
            var product = new Product(Id = id, Name = "vs 2022");
            return Ok(product);
        }
    }
}
