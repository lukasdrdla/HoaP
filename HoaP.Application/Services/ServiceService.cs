using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;

namespace HoaP.Application.Services
{
    public class ServiceService
    {
        private readonly IServiceRepository _serviceRepository;
        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<List<ServiceViewModel>> GetAllAsync()
        {
            return await _serviceRepository.GetAllAsync();
        }

        public async Task<ServiceViewModel> GetByIdAsync(int id)
        {
            return await _serviceRepository.GetByIdAsync(id);
        }
        public async Task CreateAsync(ServiceViewModel service)
        {
            await _serviceRepository.CreateAsync(service);
        }

        public async Task UpdateAsync(ServiceViewModel service)
        {
            await _serviceRepository.UpdateAsync(service);
        }

        public async Task DeleteAsync(int id)
        {
            await _serviceRepository.DeleteAsync(id);
        }


    }
}
