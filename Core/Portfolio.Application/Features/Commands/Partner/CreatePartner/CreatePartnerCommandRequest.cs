using MediatR;

namespace Portfolio.Application.Features.Commands.Partner.CreatePartner
{
    public class CreatePartnerCommandRequest : IRequest<CreatePartnerCommandResponse>
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}