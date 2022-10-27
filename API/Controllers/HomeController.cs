using Domain.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IService _service;
        public HomeController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<Top10>>> Get()
        {
            return await _service.Get();
        }
    }
}
