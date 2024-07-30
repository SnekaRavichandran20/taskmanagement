

using TaskManagementAPI.Dtos;

namespace TaskManagementAPI.Contracts
{
    public interface ITaskManagementService
    {
        Task<List<TaskListDto>> GetAllTasksAsync(Guid projectId);
        Task<TaskDto> GetTaskByIdAsync(Guid taskId);
    }
}