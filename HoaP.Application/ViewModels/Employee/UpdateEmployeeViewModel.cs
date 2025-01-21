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
        [Required]
        [StringLength(50, ErrorMessage = "First name must be between 2 and 50 characters.", MinimumLength = 2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "Last name must be between 2 and 50 characters.", MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

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
        [StringLength(50)]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string JobTitle { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Salary must be greater than or equal to 0.")]
        public decimal Salary { get; set; }

        [Required]
        public bool IsEmployed { get; set; }

        [Required]
        public int InsuranceCompanyId { get; set; }
    }

}
