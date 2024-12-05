using MediatR;

namespace Portfolio.Application.Features.Queries.RecentWork.GetByIdRecentWork
{
    public class GetByIdRecentWorkQueryRequest : IRequest<GetByIdRecentWorkQueryResponse>
    {
        public string Id { get; set; }
    }
}