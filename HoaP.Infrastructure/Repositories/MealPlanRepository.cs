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
    public class MealPlanRepository : IMealPlanRepository
    {
        private readonly ApplicationDbContext _context;

        public MealPlanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateMealPlanAsync(MealPlan entity)
        {
            await _context.MealPlans.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMealPlanAsync(int id)
        {
            var existing = await _context.MealPlans.FindAsync(id);
            if (existing != null)
            {
                _context.MealPlans.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<MealPlan?> GetMealPlanByIdAsync(int id)
        {
            return await _context.MealPlans.FindAsync(id);
        }

        public async Task<List<MealPlan>> GetMealPlansAsync()
        {
            return await _context.MealPlans.AsNoTracking().ToListAsync();
        }

        public async Task UpdateMealPlanAsync(MealPlan entity)
        {
            _context.MealPlans.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
