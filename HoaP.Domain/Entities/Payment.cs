﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Payment : AuditableEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int InvoiceId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public int PaymentMethodId { get; set; }

        public PaymentMethod? PaymentMethod { get; set; }
        public Invoice? Invoice { get; set; } 
    }
}
