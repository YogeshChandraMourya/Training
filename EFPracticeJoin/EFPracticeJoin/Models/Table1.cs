using System;
using System.Collections.Generic;

namespace EFPracticeJoin.Models;

public partial class Table1
{
    public int AvengerId { get; set; }

    public string? AvengerName { get; set; }

    public virtual ICollection<Table2> Table2s { get; set; } = new List<Table2>();
}
