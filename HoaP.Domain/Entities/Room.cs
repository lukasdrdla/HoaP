﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Room : AuditableEntity
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; } = string.Empty;
        public int RoomTypeId { get; set; }
        public int RoomStatusId { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public byte[]? Image { get; set; }
        public int MaxAdults { get; set; }
        public int MaxChildren { get; set; }
        public bool IsDisable { get; set; } = false;
        public RoomStatus? RoomStatus { get; set; }
        public RoomType? RoomType { get; set; }


        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public List<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();

    }
}
