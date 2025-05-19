
using  WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebappClassLibrary;

namespace   WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IDemo _idemo;

        public CustomerController(IDemo idemo)
        {
            _idemo = idemo;
        }
        [HttpGet("GetAllCustomers")]
        public async Task<List<CustomerModel>> GetCustomers()
        {
            return await _idemo.GetAllCustomerDetails();
        }
    }
}
