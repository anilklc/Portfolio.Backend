using Microsoft.EntityFrameworkCore;
using Portfolio.Application.Interfaces.Repositories;
using Portfolio.Domain.Common;
using Portfolio.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly PortfolioDbContext _context;
        public ReadRepository(PortfolioDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public  IQueryable<T> GetAll(bool tracking = true) => (!tracking) ? Table.AsNoTracking() : Table.AsQueryable();

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = (!tracking) ? Table.AsNoTracking() : Table.AsQueryable();
            return await query.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));

        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = (!tracking) ? Table.AsNoTracking() : Table.AsQueryable();
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = (!tracking) ? Table.AsNoTracking() : Table.AsQueryable();
            return query.Where(method);
        }
    }

}

