using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.MealPlan;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class MealPlanService
    {
        private readonly IMealPlanRepository _mealPlanRepository;
        private readonly IMapper _mapper;

        public MealPlanService(IMealPlanRepository mealPlanRepository, IMapper mapper)
        {
            _mealPlanRepository = mealPlanRepository;
            _mapper = mapper;
        }

        public async Task<List<MealPlanViewModel>> GetMealPlansAsync()
        {
            var entities = await _mealPlanRepository.GetMealPlansAsync();
            return _mapper.Map<List<MealPlanViewModel>>(entities);
        }

        public async Task<MealPlanViewModel> GetMealPlanByIdAsync(int id)
        {
            var entity = await _mealPlanRepository.GetMealPlanByIdAsync(id);
            return _mapper.Map<MealPlanViewModel>(entity);
        }

        public async Task CreateMealPlanAsync(MealPlanViewModel model)
        {
            var entity = _mapper.Map<MealPlan>(model);
            await _mealPlanRepository.CreateMealPlanAsync(entity);
        }

        public async Task UpdateMealPlanAsync(MealPlanViewModel model)
        {
            var entity = _mapper.Map<MealPlan>(model);
            await _mealPlanRepository.UpdateMealPlanAsync(entity);
        }

        public async Task DeleteMealPlanAsync(int id)
        {
            await _mealPlanRepository.DeleteMealPlanAsync(id);
        }
    }
}
