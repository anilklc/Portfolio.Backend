using MediatR;

namespace Portfolio.Application.Features.Commands.TestiMonials.RemoveTestiMonials
{
    public class RemoveTestiMonialsCommandRequest : IRequest<RemoveTestiMonialsCommandResponse>
    {
        public string Id { get; set; }
    }
}