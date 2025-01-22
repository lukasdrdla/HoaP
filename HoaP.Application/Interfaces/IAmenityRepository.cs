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
        Task<List<Amenity>> GetAmenitiesAsync();
        Task<Amenity> GetAmenityByIdAsync(int id);
        Task<Amenity> CreateAmenityAsync(Amenity amenity);
        Task<Amenity> UpdateAmenityAsync(Amenity amenity);
        Task DeleteAmenityAsync(int id);


        public Task<List<AmenityViewModel>> GetAmenitiesByRoomIdAsync(int roomId);

    }
}
