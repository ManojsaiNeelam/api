using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IDemo _idemo;

        public SupplierController(IDemo idemo)
        {
            _idemo = idemo;
        }

        [HttpGet("GetAllSuppliers")]
        public Task<List<SupplierModel>> GetSuppliers()
        {
            return _idemo.GetAllSupplierDetails();
        }
    }
}
