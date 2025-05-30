﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Application.ViewModels.Employee
{
    public class EmployeeViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }
        public string? CurrencySymbol { get; set; }

        public bool IsEmployed { get; set; }
    }

}
