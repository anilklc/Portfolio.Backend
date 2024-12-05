using MediatR;

namespace Portfolio.Application.Features.Commands.Partner.RemovePartner
{
    public class RemovePartnerCommandRequest :IRequest<RemovePartnerCommandResponse>
    {
        public string Id { get; set; }
    }
}