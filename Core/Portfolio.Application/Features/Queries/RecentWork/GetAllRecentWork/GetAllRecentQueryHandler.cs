using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.RecentWork.GetAllRecentWork
{
    public class GetAllRecentQueryHandler : IRequestHandler<GetAllRecentQueryRequest, GetAllRecentQueryResponse>
    {
        private readonly IRecentWorkReadRepository _recentWorkReadRepository;

        public GetAllRecentQueryHandler(IRecentWorkReadRepository recentWorkReadRepository)
        {
            _recentWorkReadRepository = recentWorkReadRepository;
        }

        public async Task<GetAllRecentQueryResponse> Handle(GetAllRecentQueryRequest request, CancellationToken cancellationToken)
        {
            var recents = _recentWorkReadRepository.GetAll(false).ToList();
            return new()
            {
                Recents = recents,
            };
        }
    }
}
