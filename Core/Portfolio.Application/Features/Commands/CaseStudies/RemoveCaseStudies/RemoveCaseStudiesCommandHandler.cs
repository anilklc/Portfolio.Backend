using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.CaseStudies.RemoveCaseStudies
{
    public class RemoveCaseStudiesCommandHandler : IRequestHandler<RemoveCaseStudiesCommandRequest, RemoveCaseStudiesCommandResponse>
    {
        private readonly ICaseStudiesWriteRepository _caseStudiesWriteRepository;
        public RemoveCaseStudiesCommandHandler(ICaseStudiesWriteRepository caseStudiesWriteRepository)
        {
            _caseStudiesWriteRepository = caseStudiesWriteRepository;
        }

        public async Task<RemoveCaseStudiesCommandResponse> Handle(RemoveCaseStudiesCommandRequest request, CancellationToken cancellationToken)
        {
            await _caseStudiesWriteRepository.RemoveAsync(request.Id);
            await _caseStudiesWriteRepository.SaveAsync();
            return new();
        }
    }
}
