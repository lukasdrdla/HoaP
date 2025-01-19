using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels.Customer
{
    public class CreateCustomerViewModel
    {

        [Required(ErrorMessage = "First name is required. Please provide a valid first name.")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters. Please shorten the first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required. Please provide a valid last name.")]
        [StringLength(100, ErrorMessage = "Last name cannot be longer than 100 characters. Please shorten the last name.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Document number is required. Please provide a valid document number.")]
        [StringLength(50, ErrorMessage = "Document number cannot exceed 50 characters. Please provide a valid document number.")]
        public string DocumentNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Place of birth is required. Please provide the place of birth.")]
        [StringLength(100, ErrorMessage = "Place of birth cannot exceed 100 characters. Please shorten the place of birth.")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required. Please provide a valid date of birth.")]
        [DataType(DataType.Date, ErrorMessage = "Date of birth must be a valid date. Please ensure the format is correct.")]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Date of issue is required. Please provide the issue date of the document.")]
        [DataType(DataType.Date, ErrorMessage = "Date of issue must be a valid date. Please ensure the format is correct.")]
        public DateTime DateOfIssue { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Date of expiry is required. Please provide the expiry date of the document.")]
        [DataType(DataType.Date, ErrorMessage = "Date of expiry must be a valid date. Please ensure the format is correct.")]
        public DateTime DateOfExpiry { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Personal identification number is required. Please provide a valid PIN.")]
        [StringLength(50, ErrorMessage = "Personal identification number cannot exceed 50 characters. Please provide a valid PIN.")]
        public string PersonalIdentificationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nationality is required. Please provide the nationality.")]
        [StringLength(50, ErrorMessage = "Nationality cannot exceed 50 characters. Please shorten the nationality.")]
        public string Nationality { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Please provide a valid phone number. Ensure the number contains only digits and proper formatting.")]
        [StringLength(15, ErrorMessage = "Phone number cannot exceed 15 characters. Please ensure the number is not too long.")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is required. Please provide a valid email address.")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address. Ensure the format is like example@domain.com.")]
        [StringLength(100, ErrorMessage = "Email address cannot exceed 100 characters. Please shorten the email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Address is required. Please provide the address.")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters. Please shorten the address.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "City is required. Please provide the city.")]
        [StringLength(100, ErrorMessage = "City name cannot exceed 100 characters. Please shorten the city name.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Postal code is required. Please provide the postal code.")]
        [StringLength(20, ErrorMessage = "Postal code cannot exceed 20 characters. Please shorten the postal code.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required. Please provide the country.")]
        [StringLength(100, ErrorMessage = "Country name cannot exceed 100 characters. Please shorten the country name.")]
        public string Country { get; set; } = string.Empty;

        [DataType(DataType.Date, ErrorMessage = "Creation date must be a valid date.")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.Date, ErrorMessage = "Update date must be a valid date.")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
