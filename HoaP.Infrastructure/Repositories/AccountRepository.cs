﻿using System;
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
using HoaP.Infrastructure.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AccountRepository(ApplicationDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper, RoleManager<AppRole> roleManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _roleManager = roleManager;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            var roleViewModels = _mapper.Map<List<RoleViewModel>>(roles);
            return roleViewModels;
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            return result;
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task RegisterEmployeeAsync(EmployeeFormViewModel employee)
        {
            // Ověření hesla
            if (string.IsNullOrWhiteSpace(employee.Password) || employee.Password != employee.ConfirmPassword)
            {
                throw new ArgumentException("Hesla nejsou shodná nebo je heslo prázdné.");
            }

            var existingUser = await _userManager.FindByEmailAsync(employee.Email);
            if (existingUser == null)
            {
                var user = new AppUser();
                _mapper.Map(employee, user);

                if (string.IsNullOrWhiteSpace(user.Id))
                {
                    user.Id = Guid.NewGuid().ToString();
                }

                var result = await _userManager.CreateAsync(user, employee.Password);
                if (!result.Succeeded)
                {
                    var errorMessages = string.Join("; ", result.Errors.Select(e => e.Description));
                    throw new Exception($"Vytvoření uživatele selhalo: {errorMessages}");
                }

                // ⚠️ Po úspěšném vytvoření načti znovu
                existingUser = await _userManager.FindByEmailAsync(employee.Email);
                if (existingUser == null)
                {
                    throw new Exception("Uživatel byl vytvořen, ale nepodařilo se ho znovu načíst.");
                }
            }

            // Přiřazení role
            if (!string.IsNullOrEmpty(employee.RoleId))
            {
                var role = await _roleManager.FindByIdAsync(employee.RoleId);
                if (role != null)
                {
                    var roleResult = await _userManager.AddToRoleAsync(existingUser, role.Name);
                    if (!roleResult.Succeeded)
                    {
                        var errorMessages = string.Join("; ", roleResult.Errors.Select(e => e.Description));
                        throw new Exception($"Přiřazení role selhalo: {errorMessages}");
                    }
                }
                else
                {
                    throw new Exception("Zvolená role neexistuje.");
                }
            }
        }


        public async Task UpdateUserProfileAsync(UpdateEmployeeViewModel model)
        {
            var existingUser = await _context.Users.FindAsync(model.Id);

            if (existingUser != null)
            {
                _mapper.Map(model, existingUser);
                await _userManager.UpdateAsync(existingUser);
                await _context.SaveChangesAsync();
            }

        }
    }
}
