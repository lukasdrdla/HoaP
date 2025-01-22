using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Employee;

namespace HoaP.Application.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<EmployeeViewModel>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeesAsync();
        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByIdAsync(string id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }

        public async Task UpdateEmployeeAsync(UpdateEmployeeViewModel employee)
        {
            await _employeeRepository.UpdateEmployeeAsync(employee);
        }

        public async Task DeleteEmployeeAsync(string id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task CreateEmployeeAsync(CreateEmployeeViewModel employee)
        {
            await _employeeRepository.CreateEmployeeAsync(employee);
        }

    }
}
