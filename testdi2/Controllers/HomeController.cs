using Microsoft.AspNetCore.Mvc;

namespace testdi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "HelloWorld")]
        public string Get()
        {
            return "Hello";
        }

        [HttpPost(Name = "Hello")]
        public string Get2([FromBody] Helloworld a)
        {
            return "Hello "+ a.a;
        }
    }
}
