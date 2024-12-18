﻿using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.About.RemoveAbout
{
    public class RemoveAboutCommandHandler : IRequestHandler<RemoveAboutCommandRequest, RemoveAboutCommandResponse>
    {
        private readonly IAboutWriteRepository _aboutWriteRepository;
        public RemoveAboutCommandHandler(IAboutWriteRepository aboutWriteRepository)
        {
            _aboutWriteRepository = aboutWriteRepository;
        }

        public async Task<RemoveAboutCommandResponse> Handle(RemoveAboutCommandRequest request, CancellationToken cancellationToken)
        {
            await _aboutWriteRepository.RemoveAsync(request.Id);
            await _aboutWriteRepository.SaveAsync();
            return new();
        }
    }
}
