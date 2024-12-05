using Portfolio.Application.Features.Queries.User.GetUserByUsername;
using MediatR;

namespace Portfolio.Application.Features.Queries.User.GetUserByUserId
{
    public class GetUserByUserIdQueryRequest : IRequest<GetUserByUserIdQueryResponse>
    {
        public string UserId { get; set; }
    }
}