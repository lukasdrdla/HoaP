using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;

namespace HoaP.Application.ViewModels.Customer
{
    public class CustomerFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Jméno je povinné.")]
        [StringLength(100, ErrorMessage = "Jméno nesmí být delší než 100 znaků.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Příjmení je povinné.")]
        [StringLength(100, ErrorMessage = "Příjmení nesmí být delší než 100 znaků.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Číslo dokladu je povinné.")]
        [StringLength(50, ErrorMessage = "Číslo dokladu nesmí být delší než 50 znaků.")]
        public string DocumentNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Místo narození je povinné.")]
        [StringLength(100, ErrorMessage = "Místo narození nesmí být delší než 100 znaků.")]
        public string PlaceOfBirth { get; set; } = string.Empty;

        [Required(ErrorMessage = "Datum narození je povinné.")]
        [DataType(DataType.Date, ErrorMessage = "Zadejte platné datum narození.")]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Datum vydání je povinné.")]
        [DataType(DataType.Date, ErrorMessage = "Zadejte platné datum vydání.")]
        public DateTime DateOfIssue { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Datum expirace je povinné.")]
        [DataType(DataType.Date, ErrorMessage = "Zadejte platné datum expirace.")]
        public DateTime DateOfExpiry { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Rodné číslo je povinné.")]
        [StringLength(50, ErrorMessage = "Rodné číslo nesmí být delší než 50 znaků.")]
        public string PersonalIdentificationNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Národnost je povinná.")]
        [StringLength(50, ErrorMessage = "Národnost nesmí být delší než 50 znaků.")]
        public string Nationality { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Zadejte platné telefonní číslo.")]
        [StringLength(15, ErrorMessage = "Telefonní číslo nesmí být delší než 15 znaků.")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-mail je povinný.")]
        [EmailAddress(ErrorMessage = "Zadejte platný e-mail ve tvaru například: uzivatel@domena.cz.")]
        [StringLength(100, ErrorMessage = "E-mail nesmí být delší než 100 znaků.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adresa je povinná.")]
        [StringLength(200, ErrorMessage = "Adresa nesmí být delší než 200 znaků.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Město je povinné.")]
        [StringLength(100, ErrorMessage = "Název města nesmí být delší než 100 znaků.")]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "PSČ je povinné.")]
        [StringLength(20, ErrorMessage = "PSČ nesmí být delší než 20 znaků.")]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Země je povinná.")]
        [StringLength(100, ErrorMessage = "Název země nesmí být delší než 100 znaků.")]
        public string Country { get; set; } = string.Empty;

    }

}
