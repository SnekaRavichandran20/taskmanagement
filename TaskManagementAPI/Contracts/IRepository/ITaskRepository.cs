using TaskManagementAPI.Dtos;

namespace TaskManagementAPI.Contracts
{
    public interface ITaskRepository : IRepositoryBase<TaskManagementAPI.Models.Task>
    {
        TaskDto GetTaskByIdAsync(Guid taskId);        
    }
}
