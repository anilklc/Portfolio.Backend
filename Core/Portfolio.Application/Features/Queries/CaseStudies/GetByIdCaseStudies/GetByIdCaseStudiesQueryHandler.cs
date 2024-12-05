using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.CaseStudies.GetByIdCaseStudies
{
    public class GetByIdCaseStudiesQueryHandler : IRequestHandler<GetByIdCaseStudiesQueryRequest, GetByIdCaseStudiesQueryResponse>
    {
        private readonly ICaseStudiesReadRepository _caseStudiesReadRepository;

        public GetByIdCaseStudiesQueryHandler(ICaseStudiesReadRepository caseStudiesReadRepository)
        {
            _caseStudiesReadRepository = caseStudiesReadRepository;
        }

        public async Task<GetByIdCaseStudiesQueryResponse> Handle(GetByIdCaseStudiesQueryRequest request, CancellationToken cancellationToken)
        {
            var caseStudies = await _caseStudiesReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Id = caseStudies.Id.ToString(),
                Category = caseStudies.Category,
                Detail = caseStudies.Detail,
                ImageUrl = caseStudies.ImageUrl,
                Title = caseStudies.Title,
                Url = caseStudies.Url,
            };
        }
    }
}
