using Portfolio.Application.Interfaces.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Persistence.Context;

namespace Portfolio.Persistence.Repositories
{
    public class PartnerWriteRepository : WriteRepository<Partner>, IPartnerWriteRepository
    {
        public PartnerWriteRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
