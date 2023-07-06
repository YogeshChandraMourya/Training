using System;
using System.Collections.Generic;

namespace CustomerAdmin.Models;

public partial class Customer
{
    public string CustomerName { get; set; } = null!;

    public string? Address { get; set; }

    public DateTime? LoanStartedDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int? Principle { get; set; }

    public int? RateOfInterest { get; set; }

    public int? NoOfYear { get; set; }

    public int? CalculateAmount { get { return (Principle * RateOfInterest * NoOfYear / 100); } set { } }
}
