using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.Contact.GetByIdContact
{
    public class GetByIdContactQueryHandler : IRequestHandler<GetByIdContactQueryRequest, GetByIdContactQueryResponse>
    {
        private readonly IContactReadRepository _contactReadRepository;

        public GetByIdContactQueryHandler(IContactReadRepository contactReadRepository)
        {
            _contactReadRepository = contactReadRepository;
        }

        public async Task<GetByIdContactQueryResponse> Handle(GetByIdContactQueryRequest request, CancellationToken cancellationToken)
        {
            var contact = await _contactReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Id = contact.Id.ToString(),
                Email = contact.Email,
                Message = contact.Message,
                Mobile = contact.Mobile,
            };
        }
    }
}
