using TaskManagementAPI.Contracts;
using TaskManagementAPI.Models;
using TaskManagementSystem.Data;

namespace TaskManagementAPI.Repository
{
    public class NoteRepository : RepositoryBase<Note>, INoteRepository
    {
        public NoteRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}