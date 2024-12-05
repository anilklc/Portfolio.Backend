using Portfolio.Application.DTOs.Token;
using Portfolio.Domain.Entities.Identity;

namespace Portfolio.Application.Interfaces
{
    public interface ITokenService
    {
        Token CreateToken(AppUser user);
        string GenerateRefreshToken();
    }
}
