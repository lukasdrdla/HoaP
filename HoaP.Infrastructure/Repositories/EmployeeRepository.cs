using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Employee;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;


        public EmployeeRepository(ApplicationDbContext context, IMapper mapper, UserManager<AppUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }


        public async Task CreateEmployeeAsync(CreateEmployeeViewModel employee)
        {
           var existingUser = await _userManager.FindByEmailAsync(employee.Email);
            if (existingUser == null)
            {
                var user = new AppUser
                {
                    UserName = employee.Email,
                    Email = employee.Email,
                    FirstName = employee.FirstName,
                    LastName = employee.LastName,
                    PersonalIdentificationNumber = employee.PersonalIdentificationNumber,
                    PlaceOfBirth = employee.PlaceOfBirth,
                    ProfilePicture = employee.ProfilePicture,
                    InsuranceCompanyId = employee.InsuranceCompanyId,
                    Address = employee.Address,
                    City = employee.City,
                    PostalCode = employee.PostalCode,
                    Country = employee.Country,
                    JobTitle = employee.JobTitle,
                    StartDate = employee.StartDate,
                    Salary = employee.Salary,
                    IsEmployed = employee.IsEmployed,
                    PhoneNumber = employee.PhoneNumber
                };

                await _userManager.CreateAsync(user, employee.Password);

            }

        }

        public async Task DeleteEmployeeAsync(string id)
        {
            var employee = await _context.Users.FindAsync(id);
            if (employee != null)
            {
                _context.Users.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByIdAsync(string id)
        {
            var employee = await _context.Users.FindAsync(id);
            if (employee != null)
            {
                return _mapper.Map<DetailEmployeeViewModel>(employee);
            }

            return null;
        }

        public async Task<List<EmployeeViewModel>> GetEmployeesAsync()
        {
            var employees = await _context.Users.ToListAsync();
            return _mapper.Map<List<EmployeeViewModel>>(employees);
        }

        public async Task UpdateEmployeeAsync(UpdateEmployeeViewModel employee)
        {
            throw new NotImplementedException();

        }
    }
}
