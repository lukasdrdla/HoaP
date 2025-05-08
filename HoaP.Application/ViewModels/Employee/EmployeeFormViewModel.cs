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

        public byte[] ProfilePicture { get; set; } = new byte[0];


        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage = "Heslo musí mít alespoň {2} znaků.", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
    ErrorMessage = "Heslo musí obsahovat minimálně 1 velké písmeno, 1 číslo a 1 speciální znak.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Hesla se neshodují.")]
        public string? ConfirmPassword { get; set; }


        [Required]
        [StringLength(50, ErrorMessage = "First name must be between 2 and 50 characters.", MinimumLength = 2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "Last name must be between 2 and 50 characters.", MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Address { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string City { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Country { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        public string PersonalIdentificationNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be greater than or equal to 0.")]
        public decimal Salary { get; set; }

        [Required]
        public bool IsEmployed { get; set; }

        [Required]
        public int InsuranceCompanyId { get; set; }

        [Required]
        public string? RoleId { get; set; }

        [Required]
        public int CurrencyId { get; set; }



        public List<InsuranceCompanyViewModel> InsuranceCompanies { get; set; } = new();
        public List<CurrencyViewModel> Currencies { get; set; } = new();

    }
}
