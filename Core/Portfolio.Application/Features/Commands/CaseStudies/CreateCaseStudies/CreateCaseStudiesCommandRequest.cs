using MediatR;
using System.Security;

namespace Portfolio.Application.Features.Commands.CaseStudies.CreateCaseStudies
{
    public class CreateCaseStudiesCommandRequest : IRequest<CreateCaseStudiesCommandResponse>
    {
        public string Category { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public int BoxType { get; set; }

    }
}