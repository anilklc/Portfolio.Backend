using Portfolio.Application.Interfaces.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Persistence.Context;

namespace Portfolio.Persistence.Repositories
{
    public class RecentWorkWriteRepository : WriteRepository<RecentWork>, IRecentWorkWriteRepository
    {
        public RecentWorkWriteRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
