using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTapMapaDiferenca
{
    public long TapId { get; set; }

    public decimal? ValorDiferenca { get; set; }

    public string? Maior { get; set; }
}
