using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.Partner.UpdatePartner
{
    public class UpdatePartnerCommandHandler : IRequestHandler<UpdatePartnerCommandRequest, UpdatePartnerCommandResponse>
    {
        private readonly IPartnerReadRepository _partnerReadRepository;
        private readonly IPartnerWriteRepository _partnerWriteRepository;
        public UpdatePartnerCommandHandler(IPartnerReadRepository partnerReadRepository, IPartnerWriteRepository partnerWriteRepository)
        {
            _partnerReadRepository = partnerReadRepository;
            _partnerWriteRepository = partnerWriteRepository;
        }

        public async Task<UpdatePartnerCommandResponse> Handle(UpdatePartnerCommandRequest request, CancellationToken cancellationToken)
        {
            var partner =await _partnerReadRepository.GetByIdAsync(request.Id);
            partner.ImageUrl = request.ImageUrl;
            partner.Name = request.Name;
            await _partnerWriteRepository.SaveAsync();
            return new();
        }
    }
}
