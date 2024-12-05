using MediatR;

namespace Portfolio.Application.Features.Queries.Partner.GetByIdPartner
{
    public class GetByIdPartnerQueryRequest : IRequest<GetByIdPartnerQueryResponse>
    {
        public string Id { get; set; }
    }
}