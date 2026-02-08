using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<AppUser>> GetEmployeesAsync();
        Task<AppUser?> GetEmployeeByIdAsync(string id);
        Task<AppUser?> GetEmployeeByEmail(string email);
        Task<(string roleId, string roleName)> GetEmployeeRoleAsync(string employeeId);
        Task UpdateEmployeeAsync(AppUser employee, string? roleId);
        Task DeleteEmployeeAsync(string id);
    }
}
