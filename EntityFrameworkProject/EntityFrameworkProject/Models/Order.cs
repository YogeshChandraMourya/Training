using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Models;

public partial class Order
{
    public long OrderId { get; set; }

    public long? CustomerId { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? RequiredDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public long? StoreId { get; set; }

    public long? StaffId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Staff? Staff { get; set; }

    public virtual Store? Store { get; set; }
}
