using System;
using System.Collections.Generic;

namespace EvokeWebApi.Models;

public partial class PlayersTbl
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Countryorigin { get; set; }

    public string? Skilled { get; set; }

    public string? Achievement { get; set; }
}
