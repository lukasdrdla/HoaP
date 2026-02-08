using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Role;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class RoleService
    {
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            var entities = await _roleRepository.GetRolesAsync();
            return _mapper.Map<List<RoleViewModel>>(entities);
        }

        public async Task<RoleViewModel> GetRoleByIdAsync(string id)
        {
            var entity = await _roleRepository.GetRoleByIdAsync(id);
            return _mapper.Map<RoleViewModel>(entity);
        }

        public async Task CreateRoleAsync(RoleViewModel model)
        {
            var entity = new AppRole { Name = model.Name };
            await _roleRepository.CreateRoleAsync(entity);
        }

        public async Task UpdateRoleAsync(RoleViewModel model)
        {
            var entity = _mapper.Map<AppRole>(model);
            await _roleRepository.UpdateRoleAsync(entity);
        }

        public async Task DeleteRoleAsync(string id)
        {
            await _roleRepository.DeleteRoleAsync(id);
        }
    }
}
