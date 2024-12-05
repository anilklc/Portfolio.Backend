using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.About.GetByIdAbout
{
    public class GetByIdAboutQueryHandler : IRequestHandler<GetByIdAboutQueryRequest, GetByIdAboutQueryResponse>
    {
        private readonly IAboutReadRepository _aboutReadRepository;
        public GetByIdAboutQueryHandler(IAboutReadRepository aboutReadRepository)
        {
            _aboutReadRepository = aboutReadRepository;
        }

        public async Task<GetByIdAboutQueryResponse> Handle(GetByIdAboutQueryRequest request, CancellationToken cancellationToken)
        {
            var about = await _aboutReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Title = about.Title,
                Detail = about.Detail,
                Url = about.Url,
                ImageUrl = about.ImageUrl,
            };

        }
    }
}
