using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Consts;
using Portfolio.Application.CustomAttributes;
using Portfolio.Application.Enums;
using Portfolio.Application.Features.Commands.SocialMedia.CreateSocialMedia;
using Portfolio.Application.Features.Commands.SocialMedia.RemoveSocialMedia;
using Portfolio.Application.Features.Commands.SocialMedia.UpdateSocialMedia;
using Portfolio.Application.Features.Queries.SocialMedia.GetAllSocialMedia;
using Portfolio.Application.Features.Queries.SocialMedia.GetByIdSocialMedia;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SocialMediasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.SocialMedia, ActionType = ActionType.Reading, Definition = "Get All Social Media")]
        public async Task<IActionResult> GetAllSocialMedia()
        {
            GetAllSocialMediaQueryResponse response = await _mediator.Send(new GetAllSocialMediaQueryRequest());
            return Ok(response);

        }

        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.SocialMedia, ActionType = ActionType.Reading, Definition = "Get Social Media")]
        public async Task<IActionResult> GetByIdSocialMedia([FromRoute] GetByIdSocialMediaQueryRequest request)
        {
            GetByIdSocialMediaQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.SocialMedia, ActionType = ActionType.Writing, Definition = "Create Social Media")]
        public async Task<IActionResult> CreateSocialMedia([FromBody] CreateSocialMediaCommandRequest request)
        {
            CreateSocialMediaCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.SocialMedia, ActionType = ActionType.Updating, Definition = "Update Social Media")]
        public async Task<IActionResult> UpdateSocialMedia([FromBody] UpdateSocialMediaCommandRequest request)
        {
            UpdateSocialMediaCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.SocialMedia, ActionType = ActionType.Deleting, Definition = "Delete Social Media")]
        public async Task<IActionResult> RemoveSocialMedia(string Id)
        {
            RemoveSocialMediaCommandRequest request = new RemoveSocialMediaCommandRequest { Id = Id };
            RemoveSocialMediaCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
