using TaskManagementAPI.Contracts;
using TaskManagementAPI.Models;
using TaskManagementSystem.Data;

namespace TaskManagementAPI.Repository
{
    public class UserCredentialRepository : RepositoryBase<UserCredential>, IUserCredentialRepository
    {
        public UserCredentialRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}