using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HoaP.Application.Interfaces;
using HoaP.Application.ViewModels.Payment;
using HoaP.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HoaP.Infrastructure.Repositories
{
    public class PaymentMethodRepository : IPaymentMethodRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PaymentMethodRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PaymentMethodViewModel>> GetAllPaymentMethodsAsync()
        {
            var paymentMethods = await _context.PaymentMethods.ToListAsync();
            return _mapper.Map<List<PaymentMethodViewModel>>(paymentMethods);
        }
    }
}
