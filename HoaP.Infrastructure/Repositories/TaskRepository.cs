using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Task;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TaskRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task CreateTask(TaskViewModel task, string employeeId)
        {
            var taskItem = _mapper.Map<Domain.Entities.TaskItem>(task);
            taskItem.EmployeeId = employeeId;
            await _context.TaskItems.AddAsync(taskItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTask(int id)
        {
            var existingTask = await _context.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
            if (existingTask != null)
            {
                _context.TaskItems.Remove(existingTask);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<TaskViewModel>> GetAllTasksAsync()
        {
            var tasks = await _context.TaskItems.ToListAsync();
            return _mapper.Map<List<TaskViewModel>>(tasks);
        }

        public async Task<TaskViewModel> GetTaskById(int id)
        {
            var task = await _context.TaskItems.FirstOrDefaultAsync(t => t.Id == id);
            return _mapper.Map<TaskViewModel>(task);
        }

        public async Task<List<TaskViewModel>> GetTasksForEmployeeAsync(string employeeId)
        {
            var tasks = await _context.TaskItems.Where(t => t.EmployeeId == employeeId).ToListAsync();
            return _mapper.Map<List<TaskViewModel>>(tasks);

        }

        public async Task UpdateTask(TaskViewModel task)
        {
            var existingTask = await _context.TaskItems.FirstOrDefaultAsync(t => t.Id == task.Id);
            if (existingTask != null)
            {
                _mapper.Map(task, existingTask);
                _context.TaskItems.Update(existingTask);
                await _context.SaveChangesAsync();

            
            }
        }
    }
}
