using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Consts;
using Portfolio.Application.CustomAttributes;
using Portfolio.Application.Enums;
using Portfolio.Application.Features.Commands.CaseStudies.CreateCaseStudies;
using Portfolio.Application.Features.Commands.CaseStudies.RemoveCaseStudies;
using Portfolio.Application.Features.Commands.CaseStudies.UpdateCaseStudies;
using Portfolio.Application.Features.Queries.CaseStudies.GetAllCaseStudies;
using Portfolio.Application.Features.Queries.CaseStudies.GetByIdCaseStudies;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseStudiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CaseStudiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.CaseStudies, ActionType = ActionType.Reading, Definition = "Get All Case Studie")]
        public async Task<IActionResult> GetAllCaseStudie()
        {
            GetAllCaseStudiesQueryResponse response = await _mediator.Send(new GetAllCaseStudiesQueryRequest());
            return Ok(response);

        }

        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.CaseStudies, ActionType = ActionType.Reading, Definition = "Get Case Studie")]
        public async Task<IActionResult> GetByIdCaseStudie([FromRoute] GetByIdCaseStudiesQueryRequest request)
        {
            GetByIdCaseStudiesQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.CaseStudies, ActionType = ActionType.Writing, Definition = "Create Case Studie")]
        public async Task<IActionResult> CreateCaseStudie([FromBody] CreateCaseStudiesCommandRequest request)
        {
            CreateCaseStudiesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.CaseStudies, ActionType = ActionType.Updating, Definition = "Update Case Studie")]
        public async Task<IActionResult> UpdateCaseStudie([FromBody] UpdateCaseStudiesCommandRequest request)
        {
            UpdateCaseStudiesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.CaseStudies, ActionType = ActionType.Deleting, Definition = "Delete Case Studie")]
        public async Task<IActionResult> RemoveCaseStudie(string Id)
        {
            RemoveCaseStudiesCommandRequest request = new RemoveCaseStudiesCommandRequest { Id = Id };
            RemoveCaseStudiesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
