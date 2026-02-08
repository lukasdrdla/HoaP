using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IMealPlanRepository
    {
        Task<List<MealPlan>> GetMealPlansAsync();
        Task<MealPlan?> GetMealPlanByIdAsync(int id);
        Task CreateMealPlanAsync(MealPlan entity);
        Task UpdateMealPlanAsync(MealPlan entity);
        Task DeleteMealPlanAsync(int id);
    }
}
