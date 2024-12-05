using Portfolio.Application.DTOs.Role;
using Portfolio.Application.Interfaces.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.User.GetRolesToUser
{
    public class GetRolesToUserQueryHandler : IRequestHandler<GetRolesToUserQueryRequest, GetRolesToUserQueryResponse>
    {
        private readonly IUserService _userService;

        public GetRolesToUserQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<GetRolesToUserQueryResponse> Handle(GetRolesToUserQueryRequest request, CancellationToken cancellationToken)
        {
            var assignedRoleNames = await _userService.GetRolesToUserAsync(request.UserId);

            var roles = assignedRoleNames.Select(role => new RoleDto()
            {
                Name = role
            }).ToList();

            return new()
            {
                Roles = roles,
            };
        }
    }
}
