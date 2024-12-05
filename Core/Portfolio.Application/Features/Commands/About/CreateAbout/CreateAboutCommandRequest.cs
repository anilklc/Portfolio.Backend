using MediatR;

namespace Portfolio.Application.Features.Commands.About.CreateAbout
{
    public class CreateAboutCommandRequest : IRequest<CreateAboutCommandResponse>
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
    }
}