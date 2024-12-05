using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.Partner.CreatePartner
{
    public class CreatePartnerCommandHandler : IRequestHandler<CreatePartnerCommandRequest, CreatePartnerCommandResponse>
    {
        private readonly IPartnerWriteRepository _partnerWriteRepository;
        public CreatePartnerCommandHandler(IPartnerWriteRepository partnerWriteRepository)
        {
            _partnerWriteRepository = partnerWriteRepository;
        }

        public async Task<CreatePartnerCommandResponse> Handle(CreatePartnerCommandRequest request, CancellationToken cancellationToken)
        {
            await _partnerWriteRepository.AddAsync(new()
            {
                ImageUrl = request.ImageUrl,
                Name = request.Name,
            });
            await _partnerWriteRepository.SaveAsync();
            return new();
        }
    }
}
