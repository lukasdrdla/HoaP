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
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Service entity)
        {
            await _context.Services.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var existing = await _context.Services.FindAsync(id);
            if (existing != null)
            {
                _context.Services.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Service>> GetAllAsync()
        {
            return await _context.Services.AsNoTracking().ToListAsync();
        }

        public async Task<Service?> GetByIdAsync(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public async Task UpdateAsync(Service entity)
        {
            _context.Services.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
