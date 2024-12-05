using MediatR;

namespace Portfolio.Application.Features.Queries.User.GetUserByUsername
{
    public class GetUserByUsernameQueryRequest : IRequest<GetUserByUsernameQueryResponse>
    {
        public string UserName { get; set; }
    }
}