﻿using MediatR;

namespace  Portfolio.Application.Features.Commands.User.LoginUser
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}