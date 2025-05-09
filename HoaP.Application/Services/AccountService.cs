﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.AppUser;
using HoaP.Application.ViewModels.Employee;
using HoaP.Application.ViewModels.Role;
using HoaP.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HoaP.Application.Services
{
    public class AccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await _accountRepository.LoginAsync(model);
        }

        public async Task UpdateUserAsync(UpdateEmployeeViewModel model)
        {
            await _accountRepository.UpdateUserProfileAsync(model);
        }


        public async Task RegisterEmployeeAsync(EmployeeFormViewModel employee)
        {
            await _accountRepository.RegisterEmployeeAsync(employee);
        }

        public async Task LogoutAsync()
        {
            await _accountRepository.LogoutAsync();
        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            return await _accountRepository.GetRolesAsync();
        }
    }
}
