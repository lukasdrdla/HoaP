using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Application.ViewModels.Currency;
using HoaP.Application.ViewModels.InsuranceCompany;

namespace HoaP.Application.ViewModels.Employee
{
    public class EmployeeFormViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Profilový obrázek je povinný.")]
        public byte[] ProfilePicture { get; set; } = new byte[0];

        [Required(ErrorMessage = "Uživatelské jméno je povinné.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email je povinný.")]
        [EmailAddress(ErrorMessage = "Zadejte platnou emailovou adresu.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Heslo je povinné.")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Heslo musí mít alespoň 8 znaků.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Heslo musí obsahovat alespoň 1 velké písmeno, 1 číslo a 1 speciální znak.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Potvrzení hesla je povinné.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hesla se neshodují.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Jméno je povinné.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Jméno musí mít 2 až 50 znaků.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Příjmení je povinné.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Příjmení musí mít 2 až 50 znaků.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adresa je povinná.")]
        [StringLength(100, ErrorMessage = "Adresa může mít maximálně 100 znaků.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Město je povinné.")]
        [StringLength(50, ErrorMessage = "Město může mít maximálně 50 znaků.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "PSČ je povinné.")]
        [StringLength(20, ErrorMessage = "PSČ může mít maximálně 20 znaků.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Země je povinná.")]
        [StringLength(50, ErrorMessage = "Země může mít maximálně 50 znaků.")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Rodné číslo je povinné.")]
        [StringLength(15, ErrorMessage = "Rodné číslo může mít maximálně 15 znaků.")]
        public string PersonalIdentificationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefon je povinný.")]
        [StringLength(15, ErrorMessage = "Telefon může mít maximálně 15 znaků.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Místo narození je povinné.")]
        [StringLength(50, ErrorMessage = "Místo narození může mít maximálně 50 znaků.")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [Required(ErrorMessage = "Pracovní pozice je povinná.")]
        [StringLength(50, ErrorMessage = "Pracovní pozice může mít maximálně 50 znaků.")]
        public string JobTitle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Datum nástupu je povinné.")]
        [DataType(DataType.Date, ErrorMessage = "Datum nástupu musí být platné datum.")]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Mzda je povinná.")]
        [Range(0, double.MaxValue, ErrorMessage = "Mzda musí být kladné číslo.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Zaměstnanecký stav je povinný.")]
        public bool IsEmployed { get; set; }

        [Required(ErrorMessage = "Zdravotní pojišťovna je povinná.")]
        [Range(1, int.MaxValue, ErrorMessage = "Zdravotní pojišťovna je povinná.")]
        public int InsuranceCompanyId { get; set; }

        [Required(ErrorMessage = "Role je povinná.")]
        public string? RoleId { get; set; }

        [Required(ErrorMessage = "Měna je povinná.")]
        public int CurrencyId { get; set; }

        public List<InsuranceCompanyViewModel> InsuranceCompanies { get; set; } = new();
        public List<CurrencyViewModel> Currencies { get; set; } = new();
    }
}
