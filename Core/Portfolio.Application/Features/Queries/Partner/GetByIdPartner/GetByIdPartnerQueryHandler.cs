using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.Partner.GetByIdPartner
{
    public class GetByIdPartnerQueryHandler : IRequestHandler<GetByIdPartnerQueryRequest, GetByIdPartnerQueryResponse>
    {
        private readonly IPartnerReadRepository _partnerReadRepository;
        public GetByIdPartnerQueryHandler(IPartnerReadRepository partnerReadRepository)
        {
            _partnerReadRepository = partnerReadRepository;
        }

        public async Task<GetByIdPartnerQueryResponse> Handle(GetByIdPartnerQueryRequest request, CancellationToken cancellationToken)
        {
            var partner = await _partnerReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Id = partner.Id.ToString(),
                ImageUrl = partner.ImageUrl,
                Name = partner.Name,
            };
        }
    }
}
