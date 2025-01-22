using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetTasksForEmployeeAsync(string employeeId);
        Task<List<TaskItem>> GetAllTasksAsync();
        Task<TaskItem> GetTaskById(int id);
        Task CreateTask(TaskItem task, string employeeId);
        Task UpdateTask(TaskItem task);
        Task DeleteTask(int id);
    }
}
