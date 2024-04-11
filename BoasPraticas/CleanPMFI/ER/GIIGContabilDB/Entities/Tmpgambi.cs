using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class Tmpgambi
{
    public int Idlancamento { get; set; }

    public int Idcontacontabilcredito { get; set; }

    public DateTime? Dtlancamento { get; set; }

    public decimal? Vllancamento { get; set; }

    public string? Historicos { get; set; }

    public int? Iddividafundada { get; set; }
}
