using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Employee
{
    public class DetailEmployeeViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PersonalIdentificationNumber { get; set; } = string.Empty;
        public string PlaceOfBirth { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public bool IsEmployed { get; set; }
        public string InsuranceCompanyName { get; set; } = string.Empty;
        public int InsuranceCompanyId { get; set; }

    }
}
