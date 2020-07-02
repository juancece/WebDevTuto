using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        public string Index()
        {
            return "Hello, World!";
        }
    }
}