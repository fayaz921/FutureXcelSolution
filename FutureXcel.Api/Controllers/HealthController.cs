using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutureXcel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            return Ok(new {status = "Healthy"});
        }
    }
}
