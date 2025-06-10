using Dsw2025Ej14.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
        [ApiController]
        [Route("api/products")]
    public class ProductsController : Controller
    {
        private readonly IPersistencia _persistencia;

        public ProductsController(IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }
        [HttpGet()]
        public IActionResult GetProducts()
        { 
            return Ok(_persistencia.GetProducts());
        }
    }
}
