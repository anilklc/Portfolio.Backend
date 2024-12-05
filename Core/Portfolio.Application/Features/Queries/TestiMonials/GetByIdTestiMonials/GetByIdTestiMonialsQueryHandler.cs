using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.TestiMonials.GetByIdTestiMonials
{
    public class GetByIdTestiMonialsQueryHandler : IRequestHandler<GetByIdTestiMonialsQueryRequest, GetByIdTestiMonialsQueryResponse>
    {
        private readonly ITestiMonialsReadRepository _testiMonialsReadRepository;
        public GetByIdTestiMonialsQueryHandler(ITestiMonialsReadRepository testiMonialsReadRepository)
        {
            _testiMonialsReadRepository = testiMonialsReadRepository;
        }

        public async Task<GetByIdTestiMonialsQueryResponse> Handle(GetByIdTestiMonialsQueryRequest request, CancellationToken cancellationToken)
        {
            var testiMonials = await _testiMonialsReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Id = testiMonials.Id.ToString(),
                ClientImage = testiMonials.ClientImage,
                ClientName = testiMonials.ClientName,
                Comment = testiMonials.Comment,
            };
        }
    }
}
