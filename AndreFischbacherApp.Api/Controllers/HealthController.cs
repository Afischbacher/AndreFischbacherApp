using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AndreFischbacherApp.Api.Controllers
{
    [Route("api/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get(CancellationToken cancellationToken)
        {
            return Ok(cancellationToken);
        }
    }
}
