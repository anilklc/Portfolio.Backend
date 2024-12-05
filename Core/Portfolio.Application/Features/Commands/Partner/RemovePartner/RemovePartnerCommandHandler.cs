using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.Partner.RemovePartner
{
    public class RemovePartnerCommandHandler : IRequestHandler<RemovePartnerCommandRequest, RemovePartnerCommandResponse>
    {
        private readonly IPartnerWriteRepository _partnerWriteRepository;

        public RemovePartnerCommandHandler(IPartnerWriteRepository partnerWriteRepository)
        {
            _partnerWriteRepository = partnerWriteRepository;
        }

        public async Task<RemovePartnerCommandResponse> Handle(RemovePartnerCommandRequest request, CancellationToken cancellationToken)
        {
            await _partnerWriteRepository.RemoveAsync(request.Id);
            await _partnerWriteRepository.SaveAsync();
            return new();
        }
    }
}
