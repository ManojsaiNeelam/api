using WebappClassLibrary;
using WebappClassLibrary.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly IDemo _idemo;

        public CategoryController(IDemo idemo)
        {
            _idemo = idemo;
        }

        [HttpGet("GetAllCategories")]   
        public async Task<List<UseraModel>> GetCategories()
        {
            return await  _idemo.GetAllCategoryDetails();
        }
    }
}
