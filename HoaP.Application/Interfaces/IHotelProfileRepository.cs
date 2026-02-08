using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IHotelProfileRepository
    {
        Task<HotelProfile?> GetHotelProfileAsync();
        Task SaveHotelProfileAsync(HotelProfile entity);
    }
}
