using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Task;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskViewModel>> GetTasksForEmployeeAsync(string employeeId);
        Task<List<TaskViewModel>> GetAllTasksAsync();
        Task<TaskViewModel> GetTaskById(int id);
        Task CreateTask(TaskViewModel task, string employeeId);
        Task UpdateTask(TaskViewModel task);
        Task DeleteTask(int id);
    }
}
