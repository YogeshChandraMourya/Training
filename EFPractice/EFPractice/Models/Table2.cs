using System;
using System.Collections.Generic;

namespace EFPractice.Models;

public partial class Table2
{
    public string AvengerSeries { get; set; } = null!;

    public string? SeriesName { get; set; }

    public int? AvengerId { get; set; }

    public virtual Table1? Avenger { get; set; }
}
