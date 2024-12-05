using MediatR;

namespace Portfolio.Application.Features.Commands.RecentWork.RemoveRecentWork
{
    public class RemoveRecentWorkCommandRequest : IRequest<RemoveRecentWorkCommandResponse>
    {
        public string Id { get; set; }
    }
}