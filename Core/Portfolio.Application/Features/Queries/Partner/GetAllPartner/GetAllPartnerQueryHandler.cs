using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.Partner.GetAllPartner
{
    public class GetAllPartnerQueryHandler : IRequestHandler<GetAllPartnerQueryRequest, GetAllPartnerQueryResponse>
    {
        private readonly IPartnerReadRepository _partnerReadRepository;
        public GetAllPartnerQueryHandler(IPartnerReadRepository partnerReadRepository)
        {
            _partnerReadRepository = partnerReadRepository;
        }

        public async Task<GetAllPartnerQueryResponse> Handle(GetAllPartnerQueryRequest request, CancellationToken cancellationToken)
        {
            var partners = _partnerReadRepository.GetAll(false).ToList();
            return new()
            {
                Partners = partners,
            };
        }
    }
}
