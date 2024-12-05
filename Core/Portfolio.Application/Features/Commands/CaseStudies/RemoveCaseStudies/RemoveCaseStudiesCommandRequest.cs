using MediatR;

namespace Portfolio.Application.Features.Commands.CaseStudies.RemoveCaseStudies
{
    public class RemoveCaseStudiesCommandRequest : IRequest<RemoveCaseStudiesCommandResponse>
    {
        public string Id { get; set; }
    }
}