using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.HotelProfile
{
    public class HotelProfileViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Název hotelu je povinný.")]
        [MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adresa je povinná.")]
        [MaxLength(300)]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Město je povinné.")]
        [MaxLength(100)]
        public string City { get; set; } = string.Empty;

        [Required(ErrorMessage = "PSČ je povinné.")]
        [MaxLength(10)]
        public string PostalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Země je povinná.")]
        [MaxLength(100)]
        public string Country { get; set; } = string.Empty;

        [Required(ErrorMessage = "IČO je povinné.")]
        [MaxLength(20)]
        public string ICO { get; set; } = string.Empty;

        [MaxLength(20)]
        public string DIC { get; set; } = string.Empty;

        [Phone(ErrorMessage = "Neplatné telefonní číslo.")]
        [MaxLength(20)]
        public string Phone { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Neplatný email.")]
        [MaxLength(200)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Website { get; set; } = string.Empty;

        public byte[]? Logo { get; set; }
    }
}
