using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.AppUser;
using HoaP.Application.ViewModels.Employee;
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

        public async Task<AppUser> GetCurrentUserAsync()
        {
            return await _accountRepository.GetCurrentUserAsync();
        }

        public async Task UpdateUserAsync(UpdateEmployeeViewModel model)
        {
            await _accountRepository.UpdateUserAsync(model);
        }
    }
}
