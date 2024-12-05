using MediatR;

namespace Portfolio.Application.Features.Commands.Contact.CreateContact
{
    public class CreateContactCommandRequest : IRequest<CreateContactCommandResponse>
    {   public string Email { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
    }
}