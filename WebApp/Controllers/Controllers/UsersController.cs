using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IDemo _idemo;

        public UsersController(IDemo idemo)
        {
            _idemo = idemo;
        }

        [HttpGet("GetusersDetails")]
        public async Task<List<UsersModel>> GetusersDetails()
        {
            return await _idemo.GetUsersDetails();
        }
    }
}