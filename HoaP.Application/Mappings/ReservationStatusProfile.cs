using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class ReservationStatusProfile : Profile
    {
        public ReservationStatusProfile()
        {
            CreateMap<ReservationStatus, ReservationStatusViewModel>().ReverseMap();

        }
    }
}
