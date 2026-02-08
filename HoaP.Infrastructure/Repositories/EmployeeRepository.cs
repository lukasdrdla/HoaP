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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public EmployeeRepository(ApplicationDbContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
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

        public async Task<AppUser?> GetEmployeeByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<AppUser?> GetEmployeeByIdAsync(string id)
        {
            return await _userManager.Users
                .Include(x => x.InsuranceCompany)
                .Include(x => x.Currency)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<(string roleId, string roleName)> GetEmployeeRoleAsync(string employeeId)
        {
            var employee = await _userManager.FindByIdAsync(employeeId);
            if (employee == null)
                return (string.Empty, string.Empty);

            var employeeRoles = await _userManager.GetRolesAsync(employee);
            var roleName = employeeRoles.FirstOrDefault();
            string? roleId = null;

            if (!string.IsNullOrEmpty(roleName))
            {
                var role = await _roleManager.FindByNameAsync(roleName);
                roleId = role?.Id;
            }

            return (roleId ?? string.Empty, roleName ?? string.Empty);
        }

        public async Task<List<AppUser>> GetEmployeesAsync()
        {
            return await _context.Users
                .Include(x => x.Currency)
                .ToListAsync();
        }

        public async Task UpdateEmployeeAsync(AppUser employee, string? roleId)
        {
            var existingEmployee = await _context.Users.FindAsync(employee.Id);

            if (existingEmployee == null)
                return;

            // Update role
            var currentRoles = await _userManager.GetRolesAsync(existingEmployee);
            await _userManager.RemoveFromRolesAsync(existingEmployee, currentRoles);

            if (!string.IsNullOrEmpty(roleId))
            {
                var role = await _roleManager.FindByIdAsync(roleId);
                if (role != null)
                    await _userManager.AddToRoleAsync(existingEmployee, role.Name);
            }

            // Update entity properties
            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.Email = employee.Email;
            existingEmployee.UserName = employee.UserName;
            existingEmployee.PhoneNumber = employee.PhoneNumber;
            existingEmployee.Address = employee.Address;
            existingEmployee.City = employee.City;
            existingEmployee.PostalCode = employee.PostalCode;
            existingEmployee.Country = employee.Country;
            existingEmployee.PersonalIdentificationNumber = employee.PersonalIdentificationNumber;
            existingEmployee.PlaceOfBirth = employee.PlaceOfBirth;
            existingEmployee.JobTitle = employee.JobTitle;
            existingEmployee.StartDate = employee.StartDate;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.IsEmployed = employee.IsEmployed;
            existingEmployee.InsuranceCompanyId = employee.InsuranceCompanyId;
            existingEmployee.CurrencyId = employee.CurrencyId;
            existingEmployee.ProfilePicture = employee.ProfilePicture;

            _context.Users.Update(existingEmployee);
            await _context.SaveChangesAsync();
        }
    }
}
