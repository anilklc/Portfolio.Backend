using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.RecentWork.RemoveRecentWork
{
    public class RemoveRecentWorkCommandHandler : IRequestHandler<RemoveRecentWorkCommandRequest, RemoveRecentWorkCommandResponse>
    {
        private readonly IRecentWorkWriteRepository _recentWorkWriteRepository;

        public RemoveRecentWorkCommandHandler(IRecentWorkWriteRepository recentWorkWriteRepository)
        {
            _recentWorkWriteRepository = recentWorkWriteRepository;
        }

        public async Task<RemoveRecentWorkCommandResponse> Handle(RemoveRecentWorkCommandRequest request, CancellationToken cancellationToken)
        {
            await _recentWorkWriteRepository.RemoveAsync(request.Id);
            await _recentWorkWriteRepository.SaveAsync();
            return new();
        }
    }
}
