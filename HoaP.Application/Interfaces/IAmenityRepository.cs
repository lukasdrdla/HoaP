using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Amenity;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IAmenityRepository
    {
        Task<List<AmenityViewModel>> GetAmenitiesAsync();
        Task<AmenityViewModel> GetAmenityByIdAsync(int id);
        Task CreateAmenityAsync(AmenityViewModel amenity);
        Task UpdateAmenityAsync(AmenityViewModel amenity);
        Task DeleteAmenityAsync(int id);


        public Task<List<AmenityViewModel>> GetAmenitiesByRoomIdAsync(int roomId);

    }
}
