using Portfolio.Application.Exceptions;
using Portfolio.Application.Interfaces.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.User.UpdatePassword
{
    public class UpdatePasswordCommandHandler : IRequestHandler<UpdatePasswordCommandRequest, UpdatePasswordCommandResponse>
    {
        private readonly IUserService _userService;

        public UpdatePasswordCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UpdatePasswordCommandResponse> Handle(UpdatePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            if (request.Authorized.Equals(request.Username) || request.Authorized.Equals("admin"))
            {
                await _userService.UpdatePasswordAsync(request.Username, request.Password);
                return new();
            }

            if (!request.Password.Equals(request.PasswordConfrim))
                throw new PasswordChangeException("Password change failed");


            throw new PasswordChangeException("Password change failed");
        }
    }
}
