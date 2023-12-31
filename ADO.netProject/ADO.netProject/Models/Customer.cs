﻿using System;
using System.Collections.Generic;

namespace ADO.netProject.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public long CustomerId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? ZipCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
