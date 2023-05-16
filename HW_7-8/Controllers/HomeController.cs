using Microsoft.AspNetCore.Mvc;

namespace HW_7_8.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        

        [HttpGet(Name ="Home")]
        public IActionResult Home()
        {
            return View();
        }

      
    }
}
