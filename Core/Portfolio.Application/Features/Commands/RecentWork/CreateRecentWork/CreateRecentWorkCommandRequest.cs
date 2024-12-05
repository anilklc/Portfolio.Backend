using MediatR;

namespace Portfolio.Application.Features.Commands.RecentWork.CreateRecentWork
{
    public class CreateRecentWorkCommandRequest : IRequest<CreateRecentWorkCommandResponse>
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Url { get; set; }
    }
}