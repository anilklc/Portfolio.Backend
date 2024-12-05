using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.About.CreateAbout
{
    public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, CreateAboutCommandResponse>
    {
        private readonly IAboutWriteRepository _aboutWriteRepository;

        public CreateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository)
        {
            _aboutWriteRepository = aboutWriteRepository;
        }

        public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
        {
            await _aboutWriteRepository.AddAsync(new()
            {
                Title = request.Title,
                Detail = request.Detail,
                Url = request.Url,
                ImageUrl = request.ImageUrl,
            });
            await _aboutWriteRepository.SaveAsync();
            return new();
        }
    }
}
