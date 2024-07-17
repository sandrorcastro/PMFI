using System;
using System.Collections.Generic;

namespace GIIGContabilDB.Entities;

public partial class VwContasCredore
{
    public long? NrCpf { get; set; }

    public int IdContaCredor { get; set; }

    public string? NrCc { get; set; }

    public string? NrDvCc { get; set; }

    public string? DsTipo { get; set; }

    public string? NrAgencia { get; set; }

    public string? NrDvagencia { get; set; }

    public string? CdBanco { get; set; }
}
