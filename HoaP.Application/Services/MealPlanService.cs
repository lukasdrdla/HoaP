using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.MealPlan;

namespace HoaP.Application.Services
{
    public class MealPlanService
    {
        private readonly IMealPlanRepository _mealPlanRepository;

        public MealPlanService(IMealPlanRepository mealPlanRepository)
        {
            _mealPlanRepository = mealPlanRepository;
        }

        public async Task<List<MealPlanViewModel>> GetMealPlansAsync()
        {
            return await _mealPlanRepository.GetMealPlansAsync();
        }

        public async Task<MealPlanViewModel> GetMealPlanByIdAsync(int id)
        {
            return await _mealPlanRepository.GetMealPlanByIdAsync(id);
        }

        public async Task CreateMealPlanAsync(MealPlanViewModel model)
        {
            await _mealPlanRepository.CreateMealPlanAsync(model);
        }

        public async Task UpdateMealPlanAsync(MealPlanViewModel model)
        {
            await _mealPlanRepository.UpdateMealPlanAsync(model);
        }

        public async Task DeleteMealPlanAsync(int id)
        {
            await _mealPlanRepository.DeleteMealPlanAsync(id);
        }
    }
}
