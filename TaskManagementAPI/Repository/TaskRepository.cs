using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TaskManagementAPI.Contracts;
using TaskManagementAPI.Dtos;
using TaskManagementSystem.Data;

namespace TaskManagementAPI.Repository {
    public class TaskRepository :ITaskRepository
    {
        private readonly RepositoryContext _context;
    
        public TaskRepository(RepositoryContext context)
        {
            _context = context;
        }

        public void Create(Models.Task entity)
        {
            throw new NotImplementedException();
        }

        public void CreateBatch(List<Models.Task> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Models.Task> FindByCondition(Expression<Func<Models.Task, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Models.Task FindFirstByCondition(Expression<Func<Models.Task, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public TaskDto GetTaskByIdAsync(Guid taskId)
        {
            return (from task in _context.Tasks.Where(entry => entry.IsActive && entry.Id.Equals(taskId))
                    join refterm in _context.RefTerms.Where(entry => entry.IsActive) on task.Status equals refterm.Id
                    select new TaskDto()
                    {
                        Id = task.Id,
                        Name = task.Title,
                        DueDate = task.DueDate,
                        Status = refterm.Description,
                        UserId = task.UserId,
                        Description = task.Description,
                        Notes = new List<NoteDto>()                        
                    }).FirstOrDefault();
        }

        public void Update(Models.Task entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateBatch(List<Models.Task> entities)
        {
            throw new NotImplementedException();
        }
    }
}