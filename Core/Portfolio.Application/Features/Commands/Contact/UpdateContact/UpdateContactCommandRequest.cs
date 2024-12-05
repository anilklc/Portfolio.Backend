using MediatR;

namespace Portfolio.Application.Features.Commands.Contact.UpdateContact
{
    public class UpdateContactCommandRequest :IRequest<UpdateContactCommandResponse>
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
    }
}