using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Task;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IMapper _mapper;

        public TaskService(ITaskRepository taskRepository, IMapper mapper)
        {
            _taskRepository = taskRepository;
            _mapper = mapper;
        }

        public async Task CreateTask(TaskViewModel task, string employeeId)
        {
            var entity = _mapper.Map<TaskItem>(task);
            await _taskRepository.CreateTask(entity, employeeId);
        }

        public async Task DeleteTask(int id)
        {
            await _taskRepository.DeleteTask(id);
        }

        public async Task<List<TaskViewModel>> GetAllTasksAsync()
        {
            var entities = await _taskRepository.GetAllTasksAsync();
            return _mapper.Map<List<TaskViewModel>>(entities);
        }

        public async Task<TaskViewModel> GetTaskById(int id)
        {
            var entity = await _taskRepository.GetTaskById(id);
            return _mapper.Map<TaskViewModel>(entity);
        }

        public async Task<List<TaskViewModel>> GetTasksForEmployeeAsync(string employeeId)
        {
            var entities = await _taskRepository.GetTasksForEmployeeAsync(employeeId);
            return _mapper.Map<List<TaskViewModel>>(entities);
        }

        public async Task UpdateTask(TaskViewModel task)
        {
            var entity = _mapper.Map<TaskItem>(task);
            await _taskRepository.UpdateTask(entity);
        }
    }
}
