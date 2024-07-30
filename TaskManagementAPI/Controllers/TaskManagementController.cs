using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using TaskManagementAPI.Contracts;
using TaskManagementAPI.Dtos;

namespace TaskManagementAPI.Controllers;

[ApiController]
public class TasksController : ControllerBase
{
    private readonly ITaskManagementService _taskManagementService;

    public TasksController(ITaskManagementService taskManagementService)
    {
        _taskManagementService = taskManagementService;
    }

    [HttpGet]
    [Route("/api/task/project/{project-id}")]
    public async Task<ActionResult<List<TaskListDto>>> GetTasks([FromRoute(Name = "project-id")][Required] Guid projectId)
    {
        List<TaskListDto> tasks = await _taskManagementService.GetAllTasksAsync(projectId);
        return Ok(tasks);
    }

    [HttpGet]
    [Route("/api/task/{task-id}")]
    public async Task<ActionResult<Task>> GetTask([FromRoute(Name = "task-id")][Required] Guid taskId)
    {
        TaskDto task = await _taskManagementService.GetTaskByIdAsync(taskId);
        return Ok(task);
    }
}
