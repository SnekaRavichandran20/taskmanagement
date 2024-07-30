using System.Linq.Expressions;

namespace TaskManagementAPI.Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        T FindFirstByCondition(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void CreateBatch(List<T> entities);

        void Update(T entity);

        void UpdateBatch(List<T> entities);
    }
}