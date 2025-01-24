using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Role;

namespace HoaP.Application.Services
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            return await _roleRepository.GetRolesAsync();
        }

        public async Task<RoleViewModel> GetRoleByIdAsync(string id)
        {
            return await _roleRepository.GetRoleByIdAsync(id);
        }

        public async Task CreateRoleAsync(RoleViewModel model)
        {
            await _roleRepository.CreateRoleAsync(model);
        }

        public async Task UpdateRoleAsync(RoleViewModel model)
        {
            await _roleRepository.UpdateRoleAsync(model);
        }

        public async Task DeleteRoleAsync(string id)
        {
            await _roleRepository.DeleteRoleAsync(id);
        }
    }
}
