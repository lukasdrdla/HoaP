using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.AppUser;
using HoaP.Application.ViewModels.Employee;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace HoaP.Infrastructure.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public AccountRepository(ApplicationDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<AppUser> GetCurrentUserAsync()
        {
            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
            return user;
        }

        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            return result;
        }

        public async Task UpdateUserAsync(UpdateEmployeeViewModel model)
        {
            var existingUser = await _context.Users.FindAsync(model.Id);

            if (existingUser != null)
            {
                existingUser.FirstName = model.FirstName;
                existingUser.LastName = model.LastName;
                existingUser.Address = model.Address;
                existingUser.City = model.City;
                existingUser.PostalCode = model.PostalCode;
                existingUser.PhoneNumber = model.PhoneNumber;
                existingUser.Country = model.Country;
                await _userManager.UpdateAsync(existingUser);
                await _context.SaveChangesAsync();
            }

        }
    }
}
