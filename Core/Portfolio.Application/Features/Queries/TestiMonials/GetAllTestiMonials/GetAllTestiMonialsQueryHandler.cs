using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.TestiMonials.GetAllTestiMonials
{
    public class GetAllTestiMonialsQueryHandler : IRequestHandler<GetAllTestiMonialsQueryRequest, GetAllTestiMonialsQueryResponse>
    {
        private readonly ITestiMonialsReadRepository _testiMonialsReadRepository;

        public GetAllTestiMonialsQueryHandler(ITestiMonialsReadRepository testiMonialsReadRepository)
        {
            _testiMonialsReadRepository = testiMonialsReadRepository;
        }

        public async Task<GetAllTestiMonialsQueryResponse> Handle(GetAllTestiMonialsQueryRequest request, CancellationToken cancellationToken)
        {
            var testimonials = _testiMonialsReadRepository.GetAll(false).ToList();
            return new()
            {
                TestiMonials = testimonials
            };
        }
    }
}
