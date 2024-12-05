using MediatR;

namespace Portfolio.Application.Features.Commands.SocialMedia.RemoveSocialMedia
{
    public class RemoveSocialMediaCommandRequest : IRequest<RemoveSocialMediaCommandResponse>
    {
        public string Id { get; set; }
    }
}