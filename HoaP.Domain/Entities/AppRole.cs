﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HoaP.Domain.Entities
{
    public class AppRole : IdentityRole
    {
        public string Description { get; set; } = "";
    }
}
