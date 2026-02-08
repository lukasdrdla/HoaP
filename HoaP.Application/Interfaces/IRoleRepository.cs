using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<AppRole>> GetRolesAsync();
        Task<AppRole?> GetRoleByIdAsync(string id);
        Task CreateRoleAsync(AppRole role);
        Task UpdateRoleAsync(AppRole role);
        Task DeleteRoleAsync(string id);
    }
}
