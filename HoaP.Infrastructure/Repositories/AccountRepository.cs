using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;

        public AccountRepository(ApplicationDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<List<AppRole>> GetRolesAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task<LoginResult> LoginAsync(string email, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: true);
            return new LoginResult
            {
                Succeeded = result.Succeeded,
                IsLockedOut = result.IsLockedOut,
                IsNotAllowed = result.IsNotAllowed
            };
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task RegisterEmployeeAsync(AppUser user, string password, string? roleId)
        {
            var existingUser = await _userManager.FindByEmailAsync(user.Email);
            if (existingUser == null)
            {
                if (string.IsNullOrWhiteSpace(user.Id))
                {
                    user.Id = Guid.NewGuid().ToString();
                }

                var result = await _userManager.CreateAsync(user, password);
                if (!result.Succeeded)
                {
                    var errorMessages = string.Join("; ", result.Errors.Select(e => e.Description));
                    throw new Exception($"Vytvoření uživatele selhalo: {errorMessages}");
                }

                existingUser = await _userManager.FindByEmailAsync(user.Email);
                if (existingUser == null)
                {
                    throw new Exception("Uživatel byl vytvořen, ale nepodařilo se ho znovu načíst.");
                }
            }

            if (!string.IsNullOrEmpty(roleId))
            {
                var role = await _roleManager.FindByIdAsync(roleId);
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

        public async Task UpdateUserProfileAsync(AppUser user)
        {
            var existingUser = await _context.Users.FindAsync(user.Id);

            if (existingUser != null)
            {
                existingUser.FirstName = user.FirstName;
                existingUser.LastName = user.LastName;
                existingUser.Email = user.Email;
                existingUser.UserName = user.UserName;
                existingUser.PhoneNumber = user.PhoneNumber;
                existingUser.Address = user.Address;
                existingUser.City = user.City;
                existingUser.PostalCode = user.PostalCode;
                existingUser.Country = user.Country;
                existingUser.PersonalIdentificationNumber = user.PersonalIdentificationNumber;
                existingUser.PlaceOfBirth = user.PlaceOfBirth;
                existingUser.JobTitle = user.JobTitle;
                existingUser.StartDate = user.StartDate;
                existingUser.Salary = user.Salary;
                existingUser.IsEmployed = user.IsEmployed;
                existingUser.InsuranceCompanyId = user.InsuranceCompanyId;
                existingUser.CurrencyId = user.CurrencyId;
                existingUser.ProfilePicture = user.ProfilePicture;
                await _userManager.UpdateAsync(existingUser);
                await _context.SaveChangesAsync();
            }
        }
    }
}
