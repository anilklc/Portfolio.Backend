﻿using Portfolio.Application.Features.Commands.User.FargotPassword;
using Portfolio.Application.Features.Commands.User.LoginUser;
using Portfolio.Application.Features.Commands.User.PasswordReset;
using Portfolio.Application.Features.Commands.User.RefreshTokenLogin;
using Portfolio.Application.Features.Commands.User.VerifyResetToken;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> Login([FromBody] LoginUserCommandRequest loginUserCommandRequest)
        {
            LoginUserCommandResponse response = await _mediator.Send(loginUserCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> RefreshTokenLogin([FromBody] RefreshTokenLoginCommandRequest refreshTokenLoginCommandRequest)
        {
            RefreshTokenLoginCommandResponse response = await _mediator.Send(refreshTokenLoginCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> PasswordReset([FromBody] PasswordResetCommandRequest passwordResetCommandRequest)
        {
            PasswordResetCommandResponse response = await _mediator.Send(passwordResetCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordCommandRequest ForgotPasswordCommandRequest)
        {
            ForgotPasswordCommandResponse response = await _mediator.Send(ForgotPasswordCommandRequest);
            return Ok(response);
        }

        [HttpPost("[action]")]      
        public async Task<IActionResult> VerifyResetToken([FromBody] VerifyResetTokenCommandRequest verifyResetTokenCommandRequest)
        {
            VerifyResetTokenCommandResponse response = await _mediator.Send(verifyResetTokenCommandRequest);
            return Ok(response);
        }
    }
}
