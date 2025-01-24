using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Task;

namespace HoaP.Application.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task CreateTask(TaskViewModel task, string employeeId)
        {
            await _taskRepository.CreateTask(task, employeeId);
        }

        public async Task DeleteTask(int id)
        {
            await _taskRepository.DeleteTask(id);
        }

        public async Task<List<TaskViewModel>> GetAllTasksAsync()
        {
            return await _taskRepository.GetAllTasksAsync();
        }

        public async Task<TaskViewModel> GetTaskById(int id)
        {
            return await _taskRepository.GetTaskById(id);
        }

        public async Task<List<TaskViewModel>> GetTasksForEmployeeAsync(string employeeId)
        {
            return await _taskRepository.GetTasksForEmployeeAsync(employeeId);
        }

        public async Task UpdateTask(TaskViewModel task)
        {
            await _taskRepository.UpdateTask(task);
        }
    }
}
