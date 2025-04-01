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


        

        public async Task DeleteEmployeeAsync(string id)
        {
            var employee = await _context.Users.FindAsync(id);
            if (employee != null)
            {
                _context.Users.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByEmail(string email)
        {
            var employee = await _context.Users.FirstOrDefaultAsync(x => x.Email == email);
            if (employee != null)
            {
                return _mapper.Map<DetailEmployeeViewModel>(employee);
            }

            return null;

        }

        public async Task<DetailEmployeeViewModel> GetEmployeeByIdAsync(string id)
        {
            var employee = await _context.Users
                .Include(x => x.InsuranceCompany)
                .FirstOrDefaultAsync(x => x.Id == id);
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

        public async Task UpdateEmployeeAsync(EmployeeFormViewModel employee)
        {
            var existingEmployee = await _context.Users.FindAsync(employee.Id);

            if (existingEmployee == null)
            {
                return;
            }

            _mapper.Map(employee, existingEmployee);
            _context.Users.Update(existingEmployee);
            await _context.SaveChangesAsync();



        }
    }
}
