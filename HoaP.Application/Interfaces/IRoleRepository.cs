using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Role;

namespace HoaP.Application.Interfaces
{
    public interface IRoleRepository
    {
        Task<List<RoleViewModel>> GetRolesAsync();
        Task<RoleViewModel> GetRoleByIdAsync(string id);
        Task CreateRoleAsync(RoleViewModel model);
        Task UpdateRoleAsync(RoleViewModel model);
        Task DeleteRoleAsync(string id);
    }
}
