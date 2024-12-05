using MediatR;

namespace Portfolio.Application.Features.Queries.TestiMonials.GetByIdTestiMonials
{
    public class GetByIdTestiMonialsQueryRequest : IRequest<GetByIdTestiMonialsQueryResponse>
    {
        public string Id { get; set; }
    }
}