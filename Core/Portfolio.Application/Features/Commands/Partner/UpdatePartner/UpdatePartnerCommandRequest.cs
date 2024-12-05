using MediatR;

namespace Portfolio.Application.Features.Commands.Partner.UpdatePartner
{
    public class UpdatePartnerCommandRequest : IRequest<UpdatePartnerCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}