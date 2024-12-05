using MediatR;

namespace Portfolio.Application.Features.Commands.SocialMedia.UpdateSocialMedia
{
    public class UpdateSocialMediaCommandRequest : IRequest<UpdateSocialMediaCommandResponse>
    {
        public string Id { get; set; }
        public string SocialMediaName { get; set; }
        public string SocialMediaIcon { get; set; }
        public string Url { get; set; }
    }
}