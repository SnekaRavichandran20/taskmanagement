using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TaskManagementAPI.Contracts;
using TaskManagementSystem.Data;

namespace TaskManagementAPI.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        protected RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public T FindFirstByCondition(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression).FirstOrDefault();
        }

        public void Create(T entity)
        {
            _ = RepositoryContext.Set<T>().Add(entity);
        }

        public void CreateBatch(List<T> entities)
        {
            RepositoryContext.Set<T>().AddRange(entities);
        }

        public void Update(T entity)
        {
            _ = RepositoryContext.Set<T>().Update(entity);
        }

        public void UpdateBatch(List<T> entities)
        {
            RepositoryContext.Set<T>().UpdateRange(entities);
        }
    }
}