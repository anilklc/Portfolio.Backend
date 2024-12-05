using MediatR;
using Portfolio.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Application.Features.Queries.RecentWork.GetByIdRecentWork
{
    public class GetByIdRecentWorkQueryHandler : IRequestHandler<GetByIdRecentWorkQueryRequest, GetByIdRecentWorkQueryResponse>
    {
        private readonly IRecentWorkReadRepository _recentWorkReadRepository;

        public GetByIdRecentWorkQueryHandler(IRecentWorkReadRepository recentWorkReadRepository)
        {
            _recentWorkReadRepository = recentWorkReadRepository;
        }

        public async Task<GetByIdRecentWorkQueryResponse> Handle(GetByIdRecentWorkQueryRequest request, CancellationToken cancellationToken)
        {
            var recentWork = await _recentWorkReadRepository.GetByIdAsync(request.Id);
            return new() { 
                Id = recentWork.Id.ToString(),
                Detail = recentWork.Detail,
                ImageUrl = recentWork.ImageUrl,
                Title = recentWork.Title,
                Url = recentWork.Url,
            };
        }
    }
}
