using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Commands.RecentWork.UpdateRecentWork
{
    public class UpdateRecentWorkCommandHandler : IRequestHandler<UpdateRecentWorkCommandRequest, UpdateRecentWorkCommandResponse>
    {
        private readonly IRecentWorkReadRepository _recentWorkReadRepository;
        private readonly IRecentWorkWriteRepository _recentWorkWriteRepository;
        public UpdateRecentWorkCommandHandler(IRecentWorkReadRepository recentWorkReadRepository, IRecentWorkWriteRepository recentWorkWriteRepository)
        {
            _recentWorkReadRepository = recentWorkReadRepository;
            _recentWorkWriteRepository = recentWorkWriteRepository;
        }

        public async Task<UpdateRecentWorkCommandResponse> Handle(UpdateRecentWorkCommandRequest request, CancellationToken cancellationToken)
        {
            var recentWork = await _recentWorkReadRepository.GetByIdAsync(request.Id);
            recentWork.Url = request.Url;
            recentWork.Title = request.Title;
            recentWork.Detail = request.Detail;
            recentWork.ImageUrl = request.ImageUrl;
            await _recentWorkWriteRepository.SaveAsync();
            return new();

        }

    }
}
