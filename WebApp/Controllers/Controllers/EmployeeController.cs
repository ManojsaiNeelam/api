using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDemo _idemo;

        public EmployeeController(IDemo demo)
        {
            _idemo = demo;
        }

        [HttpGet("GetAllEmployees")]
        public async Task<List<EmployeeModel>> GetEmployees()
        {
            return await _idemo.GetAllEmployeeDetails();
        }
    }
}
