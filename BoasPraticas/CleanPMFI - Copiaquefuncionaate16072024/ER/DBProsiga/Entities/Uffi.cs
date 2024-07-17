using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class Uffi
{
    public DateTime Uffidata { get; set; }

    public decimal? Uffivalor { get; set; }

    public string? UffitecUltAlt { get; set; }

    public DateTime? UffidtUltAlt { get; set; }
}
