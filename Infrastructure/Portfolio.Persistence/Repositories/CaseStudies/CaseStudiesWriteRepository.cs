using Portfolio.Application.Interfaces.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Persistence.Context;

namespace Portfolio.Persistence.Repositories
{
    public class CaseStudiesWriteRepository : WriteRepository<CaseStudies>, ICaseStudiesWriteRepository
    {
        public CaseStudiesWriteRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
