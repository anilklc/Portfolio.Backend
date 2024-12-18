﻿using Portfolio.Application.DTOs.Token;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Interfaces.Services
{
    public interface IAuthService
    {
        Task<Token> LoginAsync(string email, string password);
        Task<Token> RefreshTokenLoginAsync(string refreshToken);
        Task PasswordResetAsync(string email);
        Task<bool> VerifyResetTokenAsync(string resetToken, string userId);
    }
}
