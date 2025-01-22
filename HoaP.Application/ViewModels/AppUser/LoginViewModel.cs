using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.AppUser
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email je povinný")]
        [EmailAddress(ErrorMessage = "Neplatný formát emailu")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Heslo je povinné")]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; } = string.Empty;
    }
}
