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

        [Required(ErrorMessage = "Room number is required.")]
        [StringLength(50, ErrorMessage = "Room number cannot exceed 50 characters.")]
        public string RoomNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Room type is required.")]
        public int RoomTypeId { get; set; }

        [Required(ErrorMessage = "Room status is required.")]
        public int RoomStatusId { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 10000.00, ErrorMessage = "Price must be between 0.01 and 10000.00.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Image is required.")]
        public byte[] Image { get; set; } = null!;

        [Required(ErrorMessage = "Max adults value is required.")]
        [Range(1, 10, ErrorMessage = "Max adults must be between 1 and 10.")]
        public int MaxAdults { get; set; }

        [Required(ErrorMessage = "Max children value is required.")]
        [Range(0, 10, ErrorMessage = "Max children must be between 0 and 10.")]
        public int MaxChildren { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [DataType(DataType.DateTime)]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [ForeignKey("RoomStatusId")]
        public RoomStatus? RoomStatus { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType? RoomType { get; set; }

        public List<RoomStatusViewModel> RoomStatuses { get; set; } = new();

        public List<AmenityViewModel> Amenities { get; set; } = new();


    }
}
