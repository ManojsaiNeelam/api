using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IDemo _idemo;

        public ShipperController(IDemo idemo)
        {
            _idemo = idemo;
        }

        [HttpGet("GetAllShippers")]
        public Task<List<ShipperModel>> GetShippers() 
        { 
            return _idemo.GetAllShipperDetails();
        }

    }
}
