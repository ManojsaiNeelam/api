using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IDemo _idemo;

        public ProductController(IDemo idemo)
        {
            _idemo = idemo;
        }
        [HttpGet("GetAllProducts")]
        public Task<List<ProductModel>> GetProducts()
        {
            return _idemo.GetAllProductDetails();
        }
    }
}
