using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.MealPlan;

namespace HoaP.Application.Interfaces
{
    public interface IMealPlanRepository
    {
        Task<List<MealPlanViewModel>> GetMealPlansAsync();
        Task<MealPlanViewModel> GetMealPlanByIdAsync(int id);
        Task CreateMealPlanAsync(MealPlanViewModel model);
        Task UpdateMealPlanAsync(MealPlanViewModel model);
        Task DeleteMealPlanAsync(int id);
    }
}
