using MediatR;

namespace Portfolio.Application.Features.Queries.CaseStudies.GetByIdCaseStudies
{
    public class GetByIdCaseStudiesQueryRequest : IRequest<GetByIdCaseStudiesQueryResponse>
    {
        public string Id { get; set; }
    }
}