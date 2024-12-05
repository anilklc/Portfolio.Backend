using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.CaseStudies.UpdateCaseStudies
{
    public class UpdateCaseStudiesCommandHandler : IRequestHandler<UpdateCaseStudiesCommandRequest, UpdateCaseStudiesCommandResponse>
    {
        private readonly ICaseStudiesReadRepository _caseStudiesReadRepository;
        private readonly ICaseStudiesWriteRepository _caseStudiesWriteRepository;
        public UpdateCaseStudiesCommandHandler(ICaseStudiesReadRepository caseStudiesReadRepository, ICaseStudiesWriteRepository caseStudiesWriteRepository)
        {
            _caseStudiesReadRepository = caseStudiesReadRepository;
            _caseStudiesWriteRepository = caseStudiesWriteRepository;
        }

        public async Task<UpdateCaseStudiesCommandResponse> Handle(UpdateCaseStudiesCommandRequest request, CancellationToken cancellationToken)
        {
            var caseStudies = await _caseStudiesReadRepository.GetByIdAsync(request.Id);
            caseStudies.Detail = request.Detail;
            caseStudies.Title = request.Title;
            caseStudies.Url = request.Url;
            caseStudies.ImageUrl = request.ImageUrl;
            caseStudies.Category = request.Category;
            await _caseStudiesWriteRepository.SaveAsync();
            return new();
        }
    }
}
