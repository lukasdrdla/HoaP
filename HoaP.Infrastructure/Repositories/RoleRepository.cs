using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Role;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{ 
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleRepository(ApplicationDbContext context, IMapper mapper, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        public async Task CreateRoleAsync(RoleViewModel model)
        {
            var role = new AppRole
            {
                Name = model.Name
            };
            await _roleManager.CreateAsync(role);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteRoleAsync(string id)
        {
            var existingRole = await _roleManager.FindByIdAsync(id);

            if (existingRole == null)
            {
                throw new Exception("Role not found");
            }
            
            await _roleManager.DeleteAsync(existingRole);
            await _context.SaveChangesAsync();

        }

        public async Task<RoleViewModel> GetRoleByIdAsync(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            return _mapper.Map<RoleViewModel>(role);

        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return _mapper.Map<List<RoleViewModel>>(roles);
        }

        public async Task UpdateRoleAsync(RoleViewModel model)
        {
            var existingRole = await _roleManager.FindByIdAsync(model.Id);
            if (existingRole != null)
            {
                _mapper.Map(model, existingRole);
                await _roleManager.UpdateAsync(existingRole);
                await _context.SaveChangesAsync();
            }
        }
    }
}
