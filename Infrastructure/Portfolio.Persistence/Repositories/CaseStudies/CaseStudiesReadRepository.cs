using Portfolio.Application.Interfaces.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Persistence.Repositories
{
    public class CaseStudiesReadRepository : ReadRepository<CaseStudies>, ICaseStudiesReadRepository
    {
        public CaseStudiesReadRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
