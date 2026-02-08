using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.Interfaces
{
    public interface IPaymentRepository
    {
        Task<List<Payment>> GetPaymentsAsync();
        Task<Payment?> GetPaymentByIdAsync(Guid id);
        Task CreatePaymentAsync(Payment payment);
        Task UpdatePaymentAsync(Payment payment);
        Task DeletePaymentAsync(Guid id);

        Task<List<Payment>> GetPaymentsByReservationIdAsync(int reservationId);
    }
}
