using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Consts;
using Portfolio.Application.CustomAttributes;
using Portfolio.Application.Enums;
using Portfolio.Application.Features.Commands.RecentWork.CreateRecentWork;
using Portfolio.Application.Features.Commands.RecentWork.RemoveRecentWork;
using Portfolio.Application.Features.Commands.RecentWork.UpdateRecentWork;
using Portfolio.Application.Features.Queries.RecentWork.GetAllRecentWork;
using Portfolio.Application.Features.Queries.RecentWork.GetByIdRecentWork;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecentWorksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RecentWorksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.RecentWork, ActionType = ActionType.Reading, Definition = "Get All Recent Work")]
        public async Task<IActionResult> GetAllRecentWork()
        {
            GetAllRecentQueryResponse response = await _mediator.Send(new GetAllRecentQueryRequest());
            return Ok(response);

        }

        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.RecentWork, ActionType = ActionType.Reading, Definition = "Get Recent Work")]
        public async Task<IActionResult> GetByIdRecentWork([FromRoute] GetByIdRecentWorkQueryRequest request)
        {
            GetByIdRecentWorkQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.RecentWork, ActionType = ActionType.Writing, Definition = "Create Recent Work")]
        public async Task<IActionResult> CreateRecentWork([FromBody] CreateRecentWorkCommandRequest request)
        {
            CreateRecentWorkCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.RecentWork, ActionType = ActionType.Updating, Definition = "Update Recent Work")]
        public async Task<IActionResult> UpdateRecentWork([FromBody] UpdateRecentWorkCommandRequest request)
        {
            UpdateRecentWorkCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.RecentWork, ActionType = ActionType.Deleting, Definition = "Delete Recent Work")]
        public async Task<IActionResult> RemoveRecentWork(string Id)
        {
            RemoveRecentWorkCommandRequest request = new RemoveRecentWorkCommandRequest { Id = Id };
            RemoveRecentWorkCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
