using MediatR;

namespace Portfolio.Application.Features.Commands.Contact.RemoveContact
{
    public class RemoveContactCommandRequest : IRequest<RemoveContactCommandRespnose>
    {
        public string Id { get; set; }
    }
}