﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class RoomType : Entity<int>
    {
        public string Name { get; set; } = string.Empty;
    }
}
