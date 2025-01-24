using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Invoice;

namespace HoaP.Application.ViewModels.Payment
{
    public class PaymentFormViewModel
    {

        public Guid? Id { get; set; }

        [Required]
        public int InvoiceId { get; set; }


        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than zero.")]
        public decimal TotalAmount { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required]
        public int PaymentMethodId { get; set; }

        public List<PaymentMethodViewModel> PaymentMethods { get; set; } = new();




    }

}
