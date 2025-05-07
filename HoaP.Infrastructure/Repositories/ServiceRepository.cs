using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;
using HoaP.Domain.Entities;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ServiceRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(ServiceViewModel reservationService)
        {
            var entity = _mapper.Map<Service>(reservationService);
            await _context.Services.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Services.FindAsync(id);
            if (entity == null) throw new Exception("Služba nebyla nalezena.");

            _context.Services.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ServiceViewModel>> GetAllAsync()
        {
            var services = await _context.Services.ToListAsync();
            var serviceViewModels = _mapper.Map<List<ServiceViewModel>>(services);
            return serviceViewModels;
        }

        public async Task<ServiceViewModel> GetByIdAsync(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return null;
            }
            var serviceViewModel = _mapper.Map<ServiceViewModel>(service);
            return serviceViewModel;
        }

        public async Task UpdateAsync(ServiceViewModel reservationService)
        {
            var service = await _context.Services.FindAsync(reservationService.Id);
            if (service == null)
            {
                throw new Exception("Service not found");
            }
            _mapper.Map(reservationService, service);
            _context.Services.Update(service);
            await _context.SaveChangesAsync();
        }
    }
}
