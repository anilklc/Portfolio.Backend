﻿using MediatR;

namespace Portfolio.Application.Features.Commands.User.RefreshTokenLogin
{
    public class RefreshTokenLoginCommandRequest : IRequest<RefreshTokenLoginCommandResponse>
    {
        public string RefreshToken { get; set; }
    }
}