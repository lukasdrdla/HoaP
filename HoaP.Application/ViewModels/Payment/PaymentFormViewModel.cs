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

        [Required(ErrorMessage = "Vyberte fakturu, ke které se platba vztahuje.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vyberte fakturu, ke které se platba vztahuje.")]
        public int InvoiceId { get; set; }

        [Required(ErrorMessage = "Zadejte částku platby.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Částka platby musí být větší než nula.")]
        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "Zadejte datum a čas platby.")]
        [DataType(DataType.DateTime, ErrorMessage = "Datum platby musí být ve správném formátu.")]
        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Zvolte způsob platby.")]
        [Range(1, int.MaxValue, ErrorMessage = "Zvolte způsob platby.")]
        public int PaymentMethodId { get; set; }

        [Required(ErrorMessage = "Vyberte měnu.")]
        public int CurrencyId { get; set; }

        public List<PaymentMethodViewModel> PaymentMethods { get; set; } = new();
    }

}
