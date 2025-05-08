using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Employee;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;



        public EmployeeRepository(ApplicationDbContext context, IMapper mapper, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }




        public async Task DeleteEmployeeAsync(string id)
        {
            var employee = await _context.Users.FindAsync(id);
            if (employee != null)
            {
                _context.Users.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByEmail(string email)
        {
            var employee = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (employee != null)
            {
                return _mapper.Map<DetailEmployeeViewModel>(employee);
            }

            return null;

        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByIdAsync(string id)
        {
            var employee = await _userManager.Users
                .Include(x => x.InsuranceCompany)
                .Include(x => x.Currency)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (employee == null)
                throw new Exception("Zaměstnanec nenalezen.");

            var employeeRoles = await _userManager.GetRolesAsync(employee);

            var roleName = employeeRoles.FirstOrDefault();
            string? roleId = null;

            if (!string.IsNullOrEmpty(roleName))
            {
                var role = await _roleManager.FindByNameAsync(roleName);
                roleId = role?.Id;
            }

            var result = _mapper.Map<DetailEmployeeViewModel>(employee);
            result.RoleId = roleId ?? string.Empty;
            result.RoleName = roleName ?? string.Empty;

            return result;
        }



        public async Task<List<EmployeeViewModel>> GetEmployeesAsync()
        {
            var employees = await _context.Users
                .Include(x => x.Currency)
                .ToListAsync();
            return _mapper.Map<List<EmployeeViewModel>>(employees);
        }

        public async Task UpdateEmployeeAsync(UpdateEmployeeViewModel employee)
        {
            var existingEmployee = await _context.Users.FindAsync(employee.Id);

            if (existingEmployee == null)
                return;

            // Update role
            var currentRoles = await _userManager.GetRolesAsync(existingEmployee);
            await _userManager.RemoveFromRolesAsync(existingEmployee, currentRoles);

            var role = await _roleManager.FindByIdAsync(employee.RoleId);
            if (role != null)
                await _userManager.AddToRoleAsync(existingEmployee, role.Name);
            _mapper.Map(employee, existingEmployee);



            // Uložení změn
            _context.Users.Update(existingEmployee);
            await _context.SaveChangesAsync();
        }
    }
}
