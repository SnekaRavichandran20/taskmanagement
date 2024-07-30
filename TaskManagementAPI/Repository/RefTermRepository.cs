using TaskManagementAPI.Contracts;
using TaskManagementAPI.Models;
using TaskManagementSystem.Data;

namespace TaskManagementAPI.Repository
{
    public class RefTermRepository : RepositoryBase<RefTerm>, IRefTermRepository
    {
        public RefTermRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}