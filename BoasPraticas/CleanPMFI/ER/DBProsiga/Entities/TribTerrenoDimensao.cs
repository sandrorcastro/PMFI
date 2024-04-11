using System;
using System.Collections.Generic;

namespace DBProsiga.Entities;

public partial class TribTerrenoDimensao
{
    public long DimenId { get; set; }

    public decimal? DimenMetragem { get; set; }

    public string? DimenDescr { get; set; }

    public long? TerrenoId { get; set; }

    public DateTime? DimenData { get; set; }

    public virtual TribTerreno? Terreno { get; set; }
}
