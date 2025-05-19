using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IDemo _idemo;
        public OrderController(IDemo idemo)
        {
            _idemo = idemo;
        }
        [HttpGet("GetAllOrders")]
        public async Task<List<OrderModel>> GetOrders()
        {
            return await _idemo.GetAllOrderDetails();
        }
    }
}
