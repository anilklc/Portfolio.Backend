using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Application.Consts;
using Portfolio.Application.CustomAttributes;
using Portfolio.Application.Enums;
using Portfolio.Application.Features.Commands.Contact.CreateContact;
using Portfolio.Application.Features.Commands.Contact.RemoveContact;
using Portfolio.Application.Features.Commands.Contact.UpdateContact;
using Portfolio.Application.Features.Queries.Contact.GetAllContact;
using Portfolio.Application.Features.Queries.Contact.GetByIdContact;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Contact, ActionType = ActionType.Reading, Definition = "Get All Contact")]
        public async Task<IActionResult> GetAllContact()
        {
            GetAllContactQueryResponse response = await _mediator.Send(new GetAllContactQueryRequest());
            return Ok(response);

        }

        [HttpGet("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Contact, ActionType = ActionType.Reading, Definition = "Get Contact")]
        public async Task<IActionResult> GetByIdContact([FromRoute] GetByIdContactQueryRequest request)
        {
            GetByIdContactQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Contact, ActionType = ActionType.Writing, Definition = "Create Contact")]
        public async Task<IActionResult> CreateContact([FromBody] CreateContactCommandRequest request)
        {
            CreateContactCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Contact, ActionType = ActionType.Updating, Definition = "Update Contact")]
        public async Task<IActionResult> UpdateContact([FromBody] UpdateContactCommandRequest request)
        {
            UpdateContactCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("[action]/{Id}")]
        [Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Contact, ActionType = ActionType.Deleting, Definition = "Delete Contact")]
        public async Task<IActionResult> RemoveContact(string Id)
        {
            RemoveContactCommandRequest request = new RemoveContactCommandRequest { Id = Id };
            RemoveContactCommandRespnose response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
