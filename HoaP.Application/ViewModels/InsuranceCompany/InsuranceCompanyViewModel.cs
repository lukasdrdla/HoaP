using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.InsuranceCompany
{
    public class InsuranceCompanyViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název je povinný")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Adresa je povinná")]
        public string Address { get; set; } = string.Empty;
        [Required(ErrorMessage = "Telefonní číslo je povinné")]
        [RegularExpression(@"^\+?[0-9\s\-()]*$", ErrorMessage = "Telefonní číslo není platné")]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = "E-mail je povinný")]
        [EmailAddress(ErrorMessage = "E-mail není platný")]
        public string Email { get; set; } = string.Empty;

        public string Website { get; set; } = string.Empty;
    }
}
