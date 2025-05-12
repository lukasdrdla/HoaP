using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaP.Domain.Entities;
using HoaP.Application.ViewModels.Amenity;

namespace HoaP.Application.ViewModels.Room
{
    public class RoomFormViewModel
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "Číslo pokoje je povinné.")]
        [StringLength(50, ErrorMessage = "Číslo pokoje nesmí být delší než 50 znaků.")]
        public string RoomNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Typ pokoje je povinný.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vyberte typ pokoje.")]

        public int RoomTypeId { get; set; }

        [Required(ErrorMessage = "Stav pokoje je povinný.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vyberte stav pokoje.")]
        public int RoomStatusId { get; set; }

        [StringLength(500, ErrorMessage = "Popis nesmí být delší než 500 znaků.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Cena je povinná.")]
        [Range(0.01, 10000.00, ErrorMessage = "Cena musí být v rozmezí 0.01 až 10000.00.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Obrázek je povinný.")]
        public byte[] Image { get; set; } = null!;

        [Required(ErrorMessage = "Zadejte maximální počet dospělých.")]
        [Range(1, 10, ErrorMessage = "Maximální počet dospělých musí být mezi 1 a 10.")]
        public int MaxAdults { get; set; }

        [Required(ErrorMessage = "Zadejte maximální počet dětí.")]
        [Range(0, 10, ErrorMessage = "Maximální počet dětí musí být mezi 0 a 10.")]
        public int MaxChildren { get; set; }


        [ForeignKey("RoomStatusId")]
        public RoomStatus? RoomStatus { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType? RoomType { get; set; }

        [Required(ErrorMessage = "Vyberte měnu.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vyberte měnu.")]
        public int CurrencyId { get; set; }

        public List<RoomStatusViewModel> RoomStatuses { get; set; } = new();

        public List<AmenityViewModel> Amenities { get; set; } = new();
    }

}
