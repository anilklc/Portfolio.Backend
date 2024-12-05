using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Consts;
using Portfolio.Application.CustomAttributes;
using Portfolio.Application.Enums;
using Portfolio.Application.Features.Commands.Partner.CreatePartner;
using Portfolio.Application.Features.Commands.Partner.RemovePartner;
using Portfolio.Application.Features.Commands.Partner.UpdatePartner;
using Portfolio.Application.Features.Queries.Partner.GetAllPartner;
using Portfolio.Application.Features.Queries.Partner.GetByIdPartner;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PartnersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Partner, ActionType = ActionType.Reading, Definition = "Get All Partner")]
        public async Task<IActionResult> GetAllPartner()
        {
            GetAllPartnerQueryResponse response = await _mediator.Send(new GetAllPartnerQueryRequest());
            return Ok(response);

        }

        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Partner, ActionType = ActionType.Reading, Definition = "Get Partner")]
        public async Task<IActionResult> GetByIdPartner([FromRoute] GetByIdPartnerQueryRequest request)
        {
            GetByIdPartnerQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Partner, ActionType = ActionType.Writing, Definition = "Create Partner")]

        public async Task<IActionResult> CreatePartner([FromBody] CreatePartnerCommandRequest request)
        {
            CreatePartnerCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Partner, ActionType = ActionType.Updating, Definition = "Update Partner")]

        public async Task<IActionResult> UpdatePartner([FromBody] UpdatePartnerCommandRequest request)
        {
            UpdatePartnerCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Partner, ActionType = ActionType.Deleting, Definition = "Delete Partner")]

        public async Task<IActionResult> RemovePartner(string Id)
        {
            RemovePartnerCommandRequest request = new RemovePartnerCommandRequest { Id = Id };
            RemovePartnerCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
