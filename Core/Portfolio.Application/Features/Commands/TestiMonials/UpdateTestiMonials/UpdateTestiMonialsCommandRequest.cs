using MediatR;

namespace Portfolio.Application.Features.Commands.TestiMonials.UpdateTestiMonials
{
    public class UpdateTestiMonialsCommandRequest : IRequest<UpdateTestiMonialsCommandResponse>
    {
        public string Id { get; set; }
        public string ClientName { get; set; }
        public string ClientImage { get; set; }
        public string Comment { get; set; }
    }
}