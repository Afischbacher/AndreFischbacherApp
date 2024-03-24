using AndreFischbacherApp.Services.Features.Career.Mediator.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace AndreFischbacherApp.Api.Controllers;

[Route("api/career")]
[ApiController]
public class CareerController
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
            return Ok(await _mediator.Send(new CareerInformationCommand(), cancellationToken));
        }
        catch
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}
