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
    public class TestiMonialsReadRepository : ReadRepository<Testimonials>, ITestiMonialsReadRepository
    {
        public TestiMonialsReadRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
