using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Models;

public partial class Store
{
    public long StoreId { get; set; }

    public string? StoreName { get; set; }

    public int? Phone { get; set; }

    public string? Email { get; set; }

    public string? Street { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public int? ZipCode { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
