using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.MealPlan;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class MealPlanRepository : IMealPlanRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public MealPlanRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateMealPlanAsync(MealPlanViewModel model)
        {
            await _context.MealPlans.AddAsync(_mapper.Map<MealPlan>(model));
            await _context.SaveChangesAsync();

        }

        public async Task DeleteMealPlanAsync(int id)
        {
            var mealPlan = await _context.MealPlans.FindAsync(id);
            _context.MealPlans.Remove(mealPlan);
            await _context.SaveChangesAsync();
        }

        public async Task<MealPlanViewModel> GetMealPlanByIdAsync(int id)
        {
            var mealPlan = await _context.MealPlans.FindAsync(id);
            return _mapper.Map<MealPlanViewModel>(mealPlan);
        }

        public async Task<List<MealPlanViewModel>> GetMealPlansAsync()
        {
            var mealPlans = await _context.MealPlans.ToListAsync();
            return _mapper.Map<List<MealPlanViewModel>>(mealPlans);
        }

        public async Task UpdateMealPlanAsync(MealPlanViewModel model)
        {
            var existingMealPlan = await _context.MealPlans.FindAsync(model.Id);

            if (existingMealPlan != null)
            {
                _mapper.Map(model, existingMealPlan);
                _context.MealPlans.Update(existingMealPlan);
                await _context.SaveChangesAsync();
            }
        }
    }
}
