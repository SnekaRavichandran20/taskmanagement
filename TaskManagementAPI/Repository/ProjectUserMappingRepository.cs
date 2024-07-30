using TaskManagementAPI.Contracts;
using TaskManagementAPI.Models;
using TaskManagementSystem.Data;

namespace TaskManagementAPI.Repository
{
    public class ProjectUserMappingRepository : RepositoryBase<ProjectUserMapping>, IProjectUserMappingRepository
    {
        public ProjectUserMappingRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}