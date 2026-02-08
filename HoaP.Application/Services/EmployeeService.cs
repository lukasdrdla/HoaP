using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Employee;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeViewModel>> GetEmployeesAsync()
        {
            var entities = await _employeeRepository.GetEmployeesAsync();
            return _mapper.Map<List<EmployeeViewModel>>(entities);
        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByIdAsync(string id)
        {
            var entity = await _employeeRepository.GetEmployeeByIdAsync(id);
            if (entity == null)
                throw new Exception("Zaměstnanec nenalezen.");

            var result = _mapper.Map<DetailEmployeeViewModel>(entity);

            var (roleId, roleName) = await _employeeRepository.GetEmployeeRoleAsync(id);
            result.RoleId = roleId;
            result.RoleName = roleName;

            return result;
        }

        public async Task UpdateEmployeeAsync(UpdateEmployeeViewModel employee)
        {
            var entity = _mapper.Map<AppUser>(employee);
            await _employeeRepository.UpdateEmployeeAsync(entity, employee.RoleId);
        }

        public async Task DeleteEmployeeAsync(string id)
        {
            await _employeeRepository.DeleteEmployeeAsync(id);
        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByEmail(string email)
        {
            var entity = await _employeeRepository.GetEmployeeByEmail(email);
            return _mapper.Map<DetailEmployeeViewModel>(entity);
        }
    }
}
