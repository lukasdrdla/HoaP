using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;



        public AccountRepository(ApplicationDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
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

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task RegisterEmployeeAsync(EmployeeFormViewModel employee)
        {
            var existingUser = await _userManager.FindByEmailAsync(employee.Email);
            if (existingUser == null)
            {
                var user = new AppUser();
                _mapper.Map(employee, user);
                if (string.IsNullOrWhiteSpace(user.Id))
                {
                    user.Id = Guid.NewGuid().ToString();
                }
                await _userManager.CreateAsync(user, employee.Password);

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
