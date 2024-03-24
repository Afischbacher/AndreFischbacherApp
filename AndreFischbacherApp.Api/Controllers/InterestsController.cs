using AndreFischbacherApp.Services.Features.Interests.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace AndreFischbacherApp.Api.Controllers;

[Route("api/interests")]
[ApiController]
public class InterestsController
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
            return Ok(await _mediator.Send(new InterestsInformationCommand(), cancellationToken));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
