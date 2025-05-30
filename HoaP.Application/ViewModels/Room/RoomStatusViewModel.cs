﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Room
{
    public class RoomStatusViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Název je povinný")]
        public string Name { get; set; } = string.Empty;
    }
}
