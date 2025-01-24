using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.MealPlan;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class MealPlanProfile : Profile
    {
        public MealPlanProfile()
        {
            CreateMap<MealPlan, MealPlanViewModel>().ReverseMap();
        }
    }
}
