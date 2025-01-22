using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Payment;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IPaymentMethodRepository
    {
        Task<List<PaymentMethodViewModel>> GetAllPaymentMethodsAsync();

    }
}
