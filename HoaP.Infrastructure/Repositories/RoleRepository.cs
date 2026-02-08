using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleRepository(ApplicationDbContext context, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public async Task CreateRoleAsync(AppRole role)
        {
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

        public async Task<AppRole?> GetRoleByIdAsync(string id)
        {
            return await _roleManager.FindByIdAsync(id);
        }

        public async Task<List<AppRole>> GetRolesAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task UpdateRoleAsync(AppRole role)
        {
            var existingRole = await _roleManager.FindByIdAsync(role.Id);
            if (existingRole != null)
            {
                existingRole.Name = role.Name;
                await _roleManager.UpdateAsync(existingRole);
                await _context.SaveChangesAsync();
            }
        }
    }
}
