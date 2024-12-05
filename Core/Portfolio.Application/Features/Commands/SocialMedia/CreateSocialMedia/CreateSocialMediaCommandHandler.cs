using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.SocialMedia.CreateSocialMedia
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommandRequest, CreateSocialMediaCommandResponse>
    {
        private readonly ISocialMediaWriteRepository _socialMediaWriteRepository;

        public CreateSocialMediaCommandHandler(ISocialMediaWriteRepository socialMediaWriteRepository)
        {
            _socialMediaWriteRepository = socialMediaWriteRepository;
        }

        public async Task<CreateSocialMediaCommandResponse> Handle(CreateSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            await _socialMediaWriteRepository.AddAsync(new()
            {
                SocialMediaIcon = request.SocialMediaIcon,
                SocialMediaName = request.SocialMediaName,
                Url = request.Url, 
            });
            await _socialMediaWriteRepository.SaveAsync();
            return new();
        }
    }
}
