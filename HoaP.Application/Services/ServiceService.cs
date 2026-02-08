using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class AddonService
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;

        public AddonService(IServiceRepository serviceRepository, IMapper mapper)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
        }

        public async Task<List<ServiceViewModel>> GetAllAsync()
        {
            var entities = await _serviceRepository.GetAllAsync();
            return _mapper.Map<List<ServiceViewModel>>(entities);
        }

        public async Task<ServiceViewModel> GetByIdAsync(int id)
        {
            var entity = await _serviceRepository.GetByIdAsync(id);
            return _mapper.Map<ServiceViewModel>(entity);
        }

        public async Task CreateAsync(ServiceViewModel service)
        {
            var entity = _mapper.Map<Service>(service);
            await _serviceRepository.CreateAsync(entity);
        }

        public async Task UpdateAsync(ServiceViewModel service)
        {
            var entity = _mapper.Map<Service>(service);
            await _serviceRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _serviceRepository.DeleteAsync(id);
        }
    }
}
