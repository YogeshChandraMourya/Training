using System;
using System.Collections.Generic;

namespace EFPracticeJoin.Models;

public partial class Hero
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get { return FirstName + " " + LastName; } set { } }
}
