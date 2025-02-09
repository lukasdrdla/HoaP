using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HoaP.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public byte[]? ProfilePicture { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
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
        public int InsuranceCompanyId { get; set; }
        public InsuranceCompany? InsuranceCompany { get; set; }
    }
}
