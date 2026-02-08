using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.AppUser;
using HoaP.Application.ViewModels.Employee;
using HoaP.Application.ViewModels.Role;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class AccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;

        public AccountService(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public async Task<LoginResult> LoginAsync(LoginViewModel model)
        {
            return await _accountRepository.LoginAsync(model.Email, model.Password);
        }

        public async Task UpdateUserAsync(UpdateEmployeeViewModel model)
        {
            var user = _mapper.Map<AppUser>(model);
            await _accountRepository.UpdateUserProfileAsync(user);
        }

        public async Task RegisterEmployeeAsync(EmployeeFormViewModel employee)
        {
            if (string.IsNullOrWhiteSpace(employee.Password) || employee.Password != employee.ConfirmPassword)
            {
                throw new ArgumentException("Hesla nejsou shodná nebo je heslo prázdné.");
            }

            var user = _mapper.Map<AppUser>(employee);
            await _accountRepository.RegisterEmployeeAsync(user, employee.Password, employee.RoleId);
        }

        public async Task LogoutAsync()
        {
            await _accountRepository.LogoutAsync();
        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            var entities = await _accountRepository.GetRolesAsync();
            return _mapper.Map<List<RoleViewModel>>(entities);
        }
    }
}
