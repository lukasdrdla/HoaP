using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Employee
{
    public class UpdateEmployeeViewModel
    {
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Uživatelské jméno je povinné.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email je povinný.")]
        [EmailAddress(ErrorMessage = "Zadejte platnou emailovou adresu.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Jméno je povinné.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Příjmení je povinné.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adresa je povinná.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Město je povinné.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "PSČ je povinné.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Země je povinná.")]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "Rodné číslo je povinné.")]
        public string PersonalIdentificationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Telefon je povinný.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Místo narození je povinné.")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [Required(ErrorMessage = "Pracovní pozice je povinná.")]
        public string JobTitle { get; set; } = string.Empty;

        [Required(ErrorMessage = "Datum nástupu je povinné.")]
        [DataType(DataType.Date, ErrorMessage = "Datum nástupu musí být platné datum.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Mzda je povinná.")]
        [Range(0, double.MaxValue, ErrorMessage = "Mzda musí být větší nebo rovna nule.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Zaměstnanecký stav je povinný.")]
        public bool IsEmployed { get; set; }

        [Required(ErrorMessage = "Zdravotní pojišťovna je povinná.")]
        [Range(1, int.MaxValue, ErrorMessage = "Zdravotní pojišťovna je povinná.")]
        public int InsuranceCompanyId { get; set; }

        [Required(ErrorMessage = "Měna je povinná.")]
        public int CurrencyId { get; set; }

        [Required(ErrorMessage = "Role je povinná.")]
        public string RoleId { get; set; } = string.Empty;

        public byte[]? ProfilePicture { get; set; }
    }


}
