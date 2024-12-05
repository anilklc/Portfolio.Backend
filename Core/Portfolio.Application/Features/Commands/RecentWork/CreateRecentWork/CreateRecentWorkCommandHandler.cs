using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.RecentWork.CreateRecentWork
{
    public class CreateRecentWorkCommandHandler : IRequestHandler<CreateRecentWorkCommandRequest, CreateRecentWorkCommandResponse>
    {
        private readonly IRecentWorkWriteRepository _recentWorkWriteRepository;

        public CreateRecentWorkCommandHandler(IRecentWorkWriteRepository recentWorkWriteRepository)
        {
            _recentWorkWriteRepository = recentWorkWriteRepository;
        }

        public async Task<CreateRecentWorkCommandResponse> Handle(CreateRecentWorkCommandRequest request, CancellationToken cancellationToken)
        {
            await _recentWorkWriteRepository.AddAsync(new()
            {
                Detail = request.Detail,
                ImageUrl = request.ImageUrl,
                Url = request.Url,
                Title = request.Title,
            });
            await _recentWorkWriteRepository.SaveAsync();
            return new();
        }
    }
}
