using Portfolio.Application.DTOs.User;
using Portfolio.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<CreateUserResponse> CreateAsync(CreateUser user);
        Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime tokenDate, int refreshTokenTime);
        Task UpdatePasswordAsync(string userId, string newPassword);
        Task ForgotPasswordAsync(string userId, string resetToken, string newPassword);
        Task<List<ListUser>> GetAllUsersAsync();
        Task<ListUser> GetUserByUsernameAsync(string userName);
        Task<ListUser> GetUserByUserId(string Id);
        Task DeleteUserAsync(string Id);
        Task AssignRoleToUserAsnyc(string userId, string[] roles);
        Task<string[]> GetRolesToUserAsync(string userIdOrName);
        Task<bool> HasRolePermissionToEndpointAsync(string name, string code);

    }
}
