using MediatR;

namespace Portfolio.Application.Features.Commands.TestiMonials.CreateTestiMonials
{
    public class CreateTestiMonialsCommandRequest : IRequest<CreateTestiMonialsCommandResponse>
    {
        public string ClientName { get; set; }
        public string ClientImage { get; set; }
        public string Comment { get; set; }
    }
}