﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoaP.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string PlaceOfBirth { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public DateTime DateOfIssue { get; set; } = DateTime.Now;
        public DateTime DateOfExpiry { get; set; } = DateTime.Now;
        public string PersonalIdentificationNumber { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
