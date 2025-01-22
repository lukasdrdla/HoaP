using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IGuestRepository
    {
        Task<List<Guest>> GetGuestsAsync();
        Task<Guest> GetGuestAsync(int id);
        Task CreateGuestAsync(Guest guest);
        Task UpdateGuestAsync(Guest guest);
        Task DeleteGuestAsync(int id);
    }
}
