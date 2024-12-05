using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.CaseStudies.CreateCaseStudies
{
    public class CreateCaseStudiesCommandHandler : IRequestHandler<CreateCaseStudiesCommandRequest, CreateCaseStudiesCommandResponse>
    {
        private readonly ICaseStudiesWriteRepository _caseStudiesWriteRepository;

        public CreateCaseStudiesCommandHandler(ICaseStudiesWriteRepository caseStudiesWriteRepository)
        {
            _caseStudiesWriteRepository = caseStudiesWriteRepository;
        }

        public async Task<CreateCaseStudiesCommandResponse> Handle(CreateCaseStudiesCommandRequest request, CancellationToken cancellationToken)
        {
            await _caseStudiesWriteRepository.AddAsync(new()
            {
                Category = request.Category,
                Detail = request.Detail,
                ImageUrl = request.ImageUrl,
                Title = request.Title,
                Url = request.Url,
                BoxType = request.BoxType,
            });
            await _caseStudiesWriteRepository.SaveAsync();
            return new();
        }
    }
}
