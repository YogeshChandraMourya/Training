using System;
using System.Collections.Generic;

namespace EntityFrameworkProject.Models;

public partial class OrderItem
{
    public long? OrderId { get; set; }

    public long? ItemId { get; set; }

    public long? ProductId { get; set; }

    public int? Quantity { get; set; }

    public decimal? ListPrice { get; set; }

    public decimal? Discount { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
