using MediatR;

namespace Portfolio.Application.Features.Commands.SocialMedia.CreateSocialMedia
{
    public class CreateSocialMediaCommandRequest : IRequest<CreateSocialMediaCommandResponse>
    {
        public string SocialMediaName { get; set; }
        public string SocialMediaIcon { get; set; }
        public string Url { get; set; }
    }
}