using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.CaseStudies.GetAllCaseStudies
{
    public class GetAllCaseStudiesQueryHandler : IRequestHandler<GetAllCaseStudiesQueryRequest, GetAllCaseStudiesQueryResponse>
    {
        private readonly ICaseStudiesReadRepository _caseStudiesReadRepository;

        public GetAllCaseStudiesQueryHandler(ICaseStudiesReadRepository caseStudiesReadRepository)
        {
            _caseStudiesReadRepository = caseStudiesReadRepository;
        }

        public async Task<GetAllCaseStudiesQueryResponse> Handle(GetAllCaseStudiesQueryRequest request, CancellationToken cancellationToken)
        {
            var caseStudies = _caseStudiesReadRepository.GetAll(false).ToList();
            return new()
            {
                CaseStudies = caseStudies,
            };
        }
    }
}
