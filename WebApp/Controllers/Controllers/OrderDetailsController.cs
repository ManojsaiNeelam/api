using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IDemo _idemo;

        public OrderDetailsController(IDemo idemo)
        {
            _idemo = idemo;
        }
        [HttpGet("GetAllOrderDetails")]
        public async Task<List<OrderDetailsModel>> GetOrderDetailsinfo()
        {
            return await _idemo.GetAllOrderDetailsInformation();
        }
    }
}
