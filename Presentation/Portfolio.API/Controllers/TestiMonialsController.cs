using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Consts;
using Portfolio.Application.CustomAttributes;
using Portfolio.Application.Enums;
using Portfolio.Application.Features.Commands.TestiMonials.CreateTestiMonials;
using Portfolio.Application.Features.Commands.TestiMonials.RemoveTestiMonials;
using Portfolio.Application.Features.Commands.TestiMonials.UpdateTestiMonials;
using Portfolio.Application.Features.Queries.TestiMonials.GetAllTestiMonials;
using Portfolio.Application.Features.Queries.TestiMonials.GetByIdTestiMonials;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestiMonialsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TestiMonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.TestiMonials, ActionType = ActionType.Reading, Definition = "Get All Testi Monials")]
        public async Task<IActionResult> GetAllTestiMonials()
        {
            GetAllTestiMonialsQueryResponse response = await _mediator.Send(new GetAllTestiMonialsQueryRequest());
            return Ok(response);

        }

        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.TestiMonials, ActionType = ActionType.Reading, Definition = "Get Testi Monials")]
        public async Task<IActionResult> GetByIdTestiMonials([FromRoute] GetByIdTestiMonialsQueryRequest request)
        {
            GetByIdTestiMonialsQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.TestiMonials, ActionType = ActionType.Writing, Definition = "Create Testi Monials")]
        public async Task<IActionResult> CreateTestiMonials([FromBody] CreateTestiMonialsCommandRequest request)
        {
            CreateTestiMonialsCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.TestiMonials, ActionType = ActionType.Updating, Definition = "Update Testi Monials")]
        public async Task<IActionResult> UpdateTestiMonials([FromBody] UpdateTestiMonialsCommandRequest request)
        {
            UpdateTestiMonialsCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.TestiMonials, ActionType = ActionType.Deleting, Definition = "Delete Testi Monials")]
        public async Task<IActionResult> RemoveTestiMonials(string Id)
        {
            RemoveTestiMonialsCommandRequest request = new RemoveTestiMonialsCommandRequest { Id = Id };
            RemoveTestiMonialsCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
