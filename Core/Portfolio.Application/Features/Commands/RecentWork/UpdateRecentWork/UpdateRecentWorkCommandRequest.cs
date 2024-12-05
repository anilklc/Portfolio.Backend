using MediatR;

namespace Portfolio.Application.Features.Commands.RecentWork.UpdateRecentWork
{
    public class UpdateRecentWorkCommandRequest : IRequest<UpdateRecentWorkCommandResponse>
    {
        public string Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Url { get; set; }
    }
}