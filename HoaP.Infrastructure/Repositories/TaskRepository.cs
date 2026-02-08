using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateTask(TaskItem task, string employeeId)
        {
            task.EmployeeId = employeeId;
            await _context.TaskItems.AddAsync(task);
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

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            return await _context.TaskItems.AsNoTracking().ToListAsync();
        }

        public async Task<TaskItem?> GetTaskById(int id)
        {
            return await _context.TaskItems.AsNoTracking().FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<List<TaskItem>> GetTasksForEmployeeAsync(string employeeId)
        {
            return await _context.TaskItems
                .AsNoTracking()
                .Where(t => t.EmployeeId == employeeId)
                .ToListAsync();
        }

        public async Task UpdateTask(TaskItem task)
        {
            var existingTask = await _context.TaskItems.FirstOrDefaultAsync(t => t.Id == task.Id);
            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.IsCompleted = task.IsCompleted;
                await _context.SaveChangesAsync();
            }
        }
    }
}
