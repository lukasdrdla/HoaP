﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.ViewModels.Room;
using HoaP.Domain.Entities;

namespace HoaP.Application.Mappings
{
    public class RoomStatusProfile : Profile
    {
        public RoomStatusProfile()
        {

            CreateMap<RoomStatus, RoomStatusViewModel>().ReverseMap();



        }
    }
}
