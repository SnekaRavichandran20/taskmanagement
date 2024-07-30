using Microsoft.EntityFrameworkCore;
using TaskManagementAPI.Contracts;
using TaskManagementAPI.Dtos;

namespace TaskManagementAPI.Service {
public class TaskManagementService : ITaskManagementService
{
    private readonly IRepositoryWrapper _repoWrapper;

    public TaskManagementService(IRepositoryWrapper repoWrapper)
    {
        _repoWrapper = repoWrapper;
    }

    public async Task<List<TaskListDto>> GetAllTasksAsync(Guid projectId)
    {
        return await (from task in _repoWrapper.Task.FindByCondition(entry => entry.IsActive && entry.ProjectId.Equals(projectId))
                join refterm in _repoWrapper.RefTerm.FindByCondition(entry => entry.IsActive) on task.Status equals refterm.Id
                select new TaskListDto()
                {
                    Id = task.Id,
                    Name = task.Title,
                    DueDate = task.DueDate,
                    Status = refterm.Description,
                    UserId = task.UserId
                }).ToListAsync();
    }

    public async Task<TaskDto> GetTaskByIdAsync(Guid taskId)
    {

        TaskDto task = _repoWrapper.Task.GetTaskByIdAsync(taskId);
        
        if (task == null)
        {
            
        }

        task.Notes = (from note in _repoWrapper.Note.FindByCondition(entry => entry.IsActive && entry.TaskId.Equals(taskId))
                        join user in _repoWrapper.User.FindByCondition(entry => entry.IsActive) on note.CreatedBy equals user.Id
                        select new NoteDto()
                        {
                            Id = note.Id,
                            Content = note.Content,
                            CreatedDate = note.CreatedAt,
                            IsEdited = note.CreatedAt != note.UpdatedAt,
                            CreatedBy = user.Name,
                        }).ToList();

        task.Attachments = _repoWrapper.Attachment.FindByCondition(entry => entry.IsActive && entry.TaskId.Equals(taskId))
                            .Select(entry => new AttachmentDto()
                            {
                                Id = entry.Id,
                                FileName = entry.FileName,
                                CreatedDate = entry.CreatedAt
                            }).ToList();

        return task;
    }
}
}