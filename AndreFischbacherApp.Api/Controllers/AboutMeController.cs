using AndreFischbacherApp.Services.Features.About.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace AndreFischbacherApp.Api.Controllers;

[Route("api/about")]
[ApiController]
public class AboutMeController
    (
        IMediator mediator
    ) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    [AllowAnonymous]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {
        try
        {
            return Ok(await _mediator.Send(new AboutInformationCommand(), cancellationToken));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
