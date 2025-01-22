using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Employee;

namespace HoaP.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<EmployeeViewModel>> GetEmployeesAsync();
        Task<DetailEmployeeViewModel> GetEmployeeByIdAsync(string id);
        Task CreateEmployeeAsync(CreateEmployeeViewModel employee);
        Task UpdateEmployeeAsync(UpdateEmployeeViewModel employee);

        Task DeleteEmployeeAsync(string id);
    }
}
