using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IAmenityRepository
    {
        Task<List<Amenity>> GetAmenitiesAsync();
        Task<Amenity?> GetAmenityByIdAsync(int id);
        Task CreateAmenityAsync(Amenity entity);
        Task UpdateAmenityAsync(Amenity entity);
        Task DeleteAmenityAsync(int id);
        Task<List<Amenity>> GetAmenitiesByRoomIdAsync(int roomId);
    }
}
