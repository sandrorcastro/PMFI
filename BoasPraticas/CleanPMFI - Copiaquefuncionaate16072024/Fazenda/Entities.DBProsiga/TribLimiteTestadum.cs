using System;
using System.Collections.Generic;

namespace Fazenda.Entities.DBProsiga;

public partial class TribLimiteTestadum
{
    public int LimTid { get; set; }

    public string? LimTnome { get; set; }

    public decimal? LimTfator { get; set; }

    public int LimTpontos { get; set; }

    public virtual ICollection<TribTerreno> TribTerrenos { get; set; } = new List<TribTerreno>();
}
