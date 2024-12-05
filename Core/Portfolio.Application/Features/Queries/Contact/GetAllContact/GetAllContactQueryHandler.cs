using MediatR;
using Portfolio.Application.Features.Queries.Partner.GetAllPartner;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.Contact.GetAllContact
{
    public class GetAllContactQueryHandler : IRequestHandler<GetAllContactQueryRequest, GetAllContactQueryResponse>
    {
        private readonly IContactReadRepository _contactReadRepository;
        public GetAllContactQueryHandler(IContactReadRepository contactReadRepository)
        {
            _contactReadRepository = contactReadRepository;
        }

        public async Task<GetAllContactQueryResponse> Handle(GetAllContactQueryRequest request, CancellationToken cancellationToken)
        {
            var contacts = _contactReadRepository.GetAll(false).ToList();
            return new()
            {
                Contacts = contacts,
            };
        }
    }
}
