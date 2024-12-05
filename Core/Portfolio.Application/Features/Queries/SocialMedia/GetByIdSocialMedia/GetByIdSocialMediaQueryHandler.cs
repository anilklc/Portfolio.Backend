using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.SocialMedia.GetByIdSocialMedia
{
    public class GetByIdSocialMediaQueryHandler : IRequestHandler<GetByIdSocialMediaQueryRequest, GetByIdSocialMediaQueryResponse>
    {
        private readonly ISocialMediaReadRepository _socialMediaReadRepository;

        public GetByIdSocialMediaQueryHandler(ISocialMediaReadRepository socialMediaReadRepository)
        {
            _socialMediaReadRepository = socialMediaReadRepository;
        }

        public async Task<GetByIdSocialMediaQueryResponse> Handle(GetByIdSocialMediaQueryRequest request, CancellationToken cancellationToken)
        {
            var socialMedia = await _socialMediaReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Id = socialMedia.Id.ToString(),
                SocialMediaIcon = socialMedia.SocialMediaIcon,
                SocialMediaName = socialMedia.SocialMediaName,
                Url = socialMedia.Url,
            };
        }
    }
}
