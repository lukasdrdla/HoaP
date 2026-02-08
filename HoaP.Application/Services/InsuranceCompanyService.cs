using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.InsuranceCompany;
using HoaP.Domain.Entities;

namespace HoaP.Application.Services
{
    public class InsuranceCompanyService
    {
        private readonly IInsuranceCompanyRepository _insuranceCompanyRepository;
        private readonly IMapper _mapper;

        public InsuranceCompanyService(IInsuranceCompanyRepository insuranceCompanyRepository, IMapper mapper)
        {
            _insuranceCompanyRepository = insuranceCompanyRepository;
            _mapper = mapper;
        }

        public async Task<List<InsuranceCompanyViewModel>> GetInsuranceCompaniesAsync()
        {
            var entities = await _insuranceCompanyRepository.GetInsuranceCompaniesAsync();
            return _mapper.Map<List<InsuranceCompanyViewModel>>(entities);
        }

        public async Task<InsuranceCompanyViewModel> GetInsuranceCompanyByIdAsync(int id)
        {
            var entity = await _insuranceCompanyRepository.GetInsuranceCompanyByIdAsync(id);
            return _mapper.Map<InsuranceCompanyViewModel>(entity);
        }

        public async Task CreateInsuranceCompanyAsync(InsuranceCompanyViewModel model)
        {
            var entity = _mapper.Map<InsuranceCompany>(model);
            await _insuranceCompanyRepository.CreateInsuranceCompanyAsync(entity);
        }

        public async Task UpdateInsuranceCompanyAsync(InsuranceCompanyViewModel model)
        {
            var entity = _mapper.Map<InsuranceCompany>(model);
            await _insuranceCompanyRepository.UpdateInsuranceCompanyAsync(entity);
        }

        public async Task DeleteInsuranceCompanyAsync(int id)
        {
            await _insuranceCompanyRepository.DeleteInsuranceCompanyAsync(id);
        }
    }
}
