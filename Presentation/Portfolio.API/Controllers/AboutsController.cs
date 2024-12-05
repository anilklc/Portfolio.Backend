using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Consts;
using Portfolio.Application.CustomAttributes;
using Portfolio.Application.Enums;
using Portfolio.Application.Features.Commands.About.CreateAbout;
using Portfolio.Application.Features.Commands.About.RemoveAbout;
using Portfolio.Application.Features.Commands.About.UpdateAbout;
using Portfolio.Application.Features.Queries.About.GetAllAbout;
using Portfolio.Application.Features.Queries.About.GetByIdAbout;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AboutsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.About, ActionType = ActionType.Reading, Definition = "Get All About")]
        public async Task<IActionResult> GetAllAbout()
        {
            GetAllAboutQueryResponse response = await _mediator.Send(new GetAllAboutQueryRequest());
            return Ok(response);

        }

        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.About, ActionType = ActionType.Reading, Definition = "Get About")]
        public async Task<IActionResult> GetByIdAbout([FromRoute] GetByIdAboutQueryRequest request)
        {
            GetByIdAboutQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.About, ActionType = ActionType.Writing, Definition = "Create About")]
        public async Task<IActionResult> CreateAbout([FromBody] CreateAboutCommandRequest request)
        {
            CreateAboutCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.About, ActionType = ActionType.Updating, Definition = "Update About")]
        public async Task<IActionResult> UpdateAbout([FromBody] UpdateAboutCommandRequest request)
        {
            UpdateAboutCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.About, ActionType = ActionType.Deleting, Definition = "Delete About")]
        public async Task<IActionResult> RemoveAbout(string Id)
        {
            RemoveAboutCommandRequest request = new RemoveAboutCommandRequest { Id = Id };
            RemoveAboutCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
