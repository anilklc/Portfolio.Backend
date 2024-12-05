using MediatR;

namespace Portfolio.Application.Features.Queries.About.GetByIdAbout
{
    public class GetByIdAboutQueryRequest : IRequest<GetByIdAboutQueryResponse>
    {
        public string Id { get; set; }
    }
}