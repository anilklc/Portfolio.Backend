using Portfolio.Application.Interfaces.Repositories;
using Portfolio.Domain.Entities;
using Portfolio.Persistence.Context;

namespace Portfolio.Persistence.Repositories
{
    public class TestiMonialsWriteRepository : WriteRepository<Testimonials>, ITestiMonialsWriteRepository
    {
        public TestiMonialsWriteRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
