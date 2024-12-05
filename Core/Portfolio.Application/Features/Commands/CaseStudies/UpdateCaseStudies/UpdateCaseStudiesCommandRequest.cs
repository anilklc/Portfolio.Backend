using MediatR;

namespace Portfolio.Application.Features.Commands.CaseStudies.UpdateCaseStudies
{
    public class UpdateCaseStudiesCommandRequest : IRequest<UpdateCaseStudiesCommandResponse>
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
    }
}