using TaskManagementAPI.Contracts;
using TaskManagementAPI.Models;
using TaskManagementSystem.Data;

namespace TaskManagementAPI.Repository
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}