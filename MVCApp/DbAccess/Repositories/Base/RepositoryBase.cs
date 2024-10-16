using Contracts.Repositories.Base;
using DbAccess.Context;
using Entities.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DbAccess.Repositories.Base
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : EntityBase
    {
        private readonly LogisticContext _context;

        public RepositoryBase(LogisticContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition) =>
            _context.Set<T>().AsNoTracking().Where(condition);

        public IQueryable<T> GetAll() =>
            _context.Set<T>().AsNoTracking();
    }
}
